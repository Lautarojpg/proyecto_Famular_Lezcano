using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Helpers;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace proyecto_Famular_Lezcano
{
    public partial class UCVentas : UserControl
    {
        private ProyectoFamularLezcanoContext _context;
        private List<DetalleTemp> _detallesTemp = new List<DetalleTemp>();
        private Cliente ClienteSeleccionado;
        private Pelicula PeliculaSeleccionada;
        private VentaCabecera UltimaFactura; // guardamos la última generada

        public UCVentas()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            ConfigurarGrillaDetalle();
        }

        // ------------------------ CLIENTES ------------------------

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese nombre o apellido del cliente para buscar.");
                return;
            }

            var cliente = _context.Clientes
                .AsEnumerable()
                .FirstOrDefault(c =>
                    c.NombreCliente.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    c.ApellidoCliente.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    c.Email.Contains(texto, StringComparison.OrdinalIgnoreCase));

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con ese nombre o apellido.");
                return;
            }

            lblClienteSeleccionado.Text = $"{cliente.NombreCliente} {cliente.ApellidoCliente}";
            ClienteSeleccionado = cliente;
        }

        // ------------------------ PELÍCULAS ------------------------

        private void BtnBuscarPelicula_Click(object sender, EventArgs e)
        {
            using (var formSeleccion = new FormSeleccionarPelicula())
            {
                if (formSeleccion.ShowDialog() == DialogResult.OK)
                {
                    var pelicula = formSeleccion.PeliculaSeleccionada;

                    if (pelicula != null)
                    {
                        lblPeliculaSeleccionada.Text = pelicula.NombrePelicula;
                        PeliculaSeleccionada = pelicula;
                    }
                }
            }
        }


        // ------------------------ DETALLE ------------------------

        private void ConfigurarGrillaDetalle()
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Add("Pelicula", "Película");
            dgvDetalle.Columns.Add("Precio", "Precio");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (PeliculaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una película antes de agregar.");
                return;
            }

            int cantidad = (int)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            // 🔹 Validar stock
            var peliculaActualizada = _context.Peliculas.Find(PeliculaSeleccionada.IdPelicula);
            if (peliculaActualizada.Stock < cantidad)
            {
                MessageBox.Show($"No hay suficiente stock. Disponible: {peliculaActualizada.Stock}.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = peliculaActualizada.Precio * cantidad;

            _detallesTemp.Add(new DetalleTemp
            {
                IdPelicula = peliculaActualizada.IdPelicula,
                NombrePelicula = peliculaActualizada.NombrePelicula,
                Precio = peliculaActualizada.Precio,
                Cantidad = cantidad,
                Subtotal = subtotal
            });

            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            dgvDetalle.Rows.Clear();
            foreach (var d in _detallesTemp)
            {
                dgvDetalle.Rows.Add(d.NombrePelicula, d.Precio, d.Cantidad, d.Subtotal);
            }

            lblTotal.Text = $"Total: ${_detallesTemp.Sum(x => x.Subtotal):0.00}";
        }

        // ------------------------ GUARDAR FACTURA ------------------------

        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (ClienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de guardar la factura.");
                return;
            }

            if (!_detallesTemp.Any())
            {
                MessageBox.Show("Debe agregar al menos una película antes de guardar.");
                return;
            }

            if (SesionActual.Usuario == null)
            {
                MessageBox.Show("No se detectó un usuario activo. Inicie sesión nuevamente.");
                return;
            }

            try
            {
                // 🔹 Verificar stock disponible antes de continuar
                foreach (var d in _detallesTemp)
                {
                    var pelicula = _context.Peliculas.Find(d.IdPelicula);
                    if (pelicula.Stock < d.Cantidad)
                    {
                        MessageBox.Show($"La película '{pelicula.NombrePelicula}' no tiene suficiente stock. Disponible: {pelicula.Stock}.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 🔹 Crear cabecera
                var nuevaCabecera = new VentaCabecera
                {
                    FechaCompra = DateTime.Now,
                    IdCliente = ClienteSeleccionado.IdCliente,
                    TotalVenta = _detallesTemp.Sum(x => x.Subtotal)
                };

                _context.VentaCabeceras.Add(nuevaCabecera);
                _context.SaveChanges();

                // 🔹 Crear detalles y actualizar stock
                foreach (var d in _detallesTemp)
                {
                    var pelicula = _context.Peliculas.Find(d.IdPelicula);

                    pelicula.Stock -= d.Cantidad;
                    _context.Peliculas.Update(pelicula);

                    var detalle = new VentaDetalle
                    {
                        IdVenta = nuevaCabecera.IdVenta,
                        IdPelicula = d.IdPelicula,
                        Cantidad = d.Cantidad,
                        IdUsuario = SesionActual.Usuario.IdUsuario
                    };
                    _context.VentaDetalles.Add(detalle);
                }

                _context.SaveChanges();

                UltimaFactura = nuevaCabecera;

                MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string pdfPath = GenerarFacturaPDF(UltimaFactura, ClienteSeleccionado);
                if (pdfPath != null)
                {
                    MessageBox.Show($"Factura PDF generada correctamente en:\n{pdfPath}", "PDF Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                _detallesTemp.Clear();
                RefrescarGrilla();
                lblClienteSeleccionado.Text = "";
                lblPeliculaSeleccionada.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}");
            }
        }

        private void BtnMisFacturas_Click(object sender, EventArgs e)
        {
            FormMisFacturas frm = new FormMisFacturas();
            frm.ShowDialog();
        }

        // ------------------------ EXPORTAR PDF ------------------------
        private string GenerarFacturaPDF(VentaCabecera factura, Cliente cliente)
        {
            try
            {
                var detalles = _context.VentaDetalles
                    .Include(v => v.IdPeliculaNavigation)
                    .Where(v => v.IdVenta == factura.IdVenta)
                    .ToList();

                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FacturasPDF");
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, $"Factura_{factura.IdVenta}.pdf");

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 50, 50, 50, 50);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Título
                    var titulo = new Paragraph("FACTURA DE VENTA\n\n", iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(titulo);

                    // Datos generales
                    pdfDoc.Add(new Paragraph($"Factura N°: {factura.IdVenta}"));
                    pdfDoc.Add(new Paragraph($"Fecha: {factura.FechaCompra:dd/MM/yyyy}"));
                    pdfDoc.Add(new Paragraph($"Cliente: {cliente.NombreCliente} {cliente.ApellidoCliente}"));
                    pdfDoc.Add(new Paragraph($"Total: ${factura.TotalVenta:0.00}\n\n"));

                    // Tabla de detalle
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.AddCell("Película");
                    table.AddCell("Precio");
                    table.AddCell("Cantidad");
                    table.AddCell("Subtotal");

                    foreach (var d in detalles)
                    {
                        table.AddCell(d.IdPeliculaNavigation.NombrePelicula);
                        table.AddCell($"${d.IdPeliculaNavigation.Precio:0.00}");
                        table.AddCell(d.Cantidad.ToString());
                        table.AddCell($"${d.IdPeliculaNavigation.Precio * d.Cantidad:0.00}");
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }

                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}");
                return null;
            }
        }


        // ------------------------ ENVIAR CSV POR CORREO ------------------------
        private void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (UltimaFactura == null)
            {
                MessageBox.Show("No hay ninguna factura reciente para enviar.");
                return;
            }

            if (string.IsNullOrEmpty(ClienteSeleccionado?.Email))
            {
                MessageBox.Show("El cliente no tiene un correo electrónico registrado.");
                return;
            }

            // 🔹 Generar PDF temporal de la factura
            string pdfPath = Path.Combine(Path.GetTempPath(), $"Factura_{UltimaFactura.IdVenta}.pdf");

            try
            {
                var detalles = _context.VentaDetalles
                    .Include(v => v.IdPeliculaNavigation)
                    .Where(v => v.IdVenta == UltimaFactura.IdVenta)
                    .ToList();

                // Crear documento PDF
                using (var fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Encabezado
                    var fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    var fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    doc.Add(new Paragraph($"Factura N° {UltimaFactura.IdVenta}", fontTitulo));
                    doc.Add(new Paragraph($"Fecha: {UltimaFactura.FechaCompra:dd/MM/yyyy}", fontNormal));
                    doc.Add(new Paragraph($"Cliente: {ClienteSeleccionado.NombreCliente} {ClienteSeleccionado.ApellidoCliente}", fontNormal));
                    doc.Add(new Paragraph($"Email: {ClienteSeleccionado.Email}", fontNormal));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph("Detalle de la compra:", fontNormal));
                    doc.Add(new Paragraph(" "));

                    // Tabla de detalle
                    PdfPTable tabla = new PdfPTable(4);
                    tabla.WidthPercentage = 100;
                    tabla.SetWidths(new float[] { 40, 20, 20, 20 });

                    tabla.AddCell("Película");
                    tabla.AddCell("Precio");
                    tabla.AddCell("Cantidad");
                    tabla.AddCell("Subtotal");

                    foreach (var d in detalles)
                    {
                        tabla.AddCell(d.IdPeliculaNavigation.NombrePelicula);
                        tabla.AddCell($"${d.IdPeliculaNavigation.Precio:0.00}");
                        tabla.AddCell(d.Cantidad.ToString());
                        tabla.AddCell($"${d.IdPeliculaNavigation.Precio * d.Cantidad:0.00}");
                    }

                    doc.Add(tabla);
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph($"Total: ${UltimaFactura.TotalVenta:0.00}", fontTitulo));
                    doc.Close();
                }

                // 🔹 Enviar correo con el PDF adjunto
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lautarofranciscolezcano@gmail.com");
                mail.To.Add(ClienteSeleccionado.Email);
                mail.Subject = $"Factura #{UltimaFactura.IdVenta}";
                mail.Body = $"Estimado/a {ClienteSeleccionado.NombreCliente},\n\nAdjuntamos su factura #{UltimaFactura.IdVenta} en formato PDF.\n\nGracias por su compra.\n\nSaludos cordiales.";
                mail.Attachments.Add(new Attachment(pdfPath));

                // Configuración SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("lautarofranciscolezcano@gmail.com", "Lau46381127");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Factura en PDF enviada correctamente al correo del cliente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar o enviar la factura PDF: {ex.Message}");
            }
            finally
            {
                // Eliminar PDF temporal
                if (File.Exists(pdfPath))
                {
                    try { File.Delete(pdfPath); } catch { }
                }
            }
        }

    }
}
