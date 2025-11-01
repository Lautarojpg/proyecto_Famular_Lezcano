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
                    c.ApellidoCliente.Contains(texto, StringComparison.OrdinalIgnoreCase));

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
            string texto = txtBuscarPelicula.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese un nombre de película para buscar.");
                return;
            }

            var pelicula = _context.Peliculas
                .FirstOrDefault(p => p.NombrePelicula.ToLower().Contains(texto.ToLower()));

            if (pelicula == null)
            {
                MessageBox.Show("No se encontró ninguna película con ese nombre.");
                return;
            }

            lblPeliculaSeleccionada.Text = pelicula.NombrePelicula;
            PeliculaSeleccionada = pelicula;
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

        // ------------------------ EXPORTAR CSV ------------------------
        private void BtnExportarCSV_Click(object sender, EventArgs e)
        {
            if (UltimaFactura == null)
            {
                MessageBox.Show("No hay ninguna factura reciente para exportar.");
                return;
            }

            var detalles = _context.VentaDetalles
                .Include(v => v.IdPeliculaNavigation)
                .Where(v => v.IdVenta == UltimaFactura.IdVenta)
                .ToList();

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                FileName = $"Factura_{UltimaFactura.IdVenta}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("Factura N°;Fecha;Cliente;Total");
                    writer.WriteLine($"{UltimaFactura.IdVenta};{UltimaFactura.FechaCompra:dd/MM/yyyy};{ClienteSeleccionado.NombreCliente} {ClienteSeleccionado.ApellidoCliente};{UltimaFactura.TotalVenta}");
                    writer.WriteLine();
                    writer.WriteLine("Película;Precio;Cantidad;Subtotal");

                    foreach (var d in detalles)
                    {
                        writer.WriteLine($"{d.IdPeliculaNavigation.NombrePelicula};{d.IdPeliculaNavigation.Precio};{d.Cantidad};{d.IdPeliculaNavigation.Precio * d.Cantidad}");
                    }
                }

                MessageBox.Show("Factura exportada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrEmpty(ClienteSeleccionado.Email))
            {
                MessageBox.Show("El cliente no tiene un correo electrónico registrado.");
                return;
            }

            // Primero generamos el CSV temporal
            string tempPath = Path.Combine(Path.GetTempPath(), $"Factura_{UltimaFactura.IdVenta}.csv");

            var detalles = _context.VentaDetalles
                .Include(v => v.IdPeliculaNavigation)
                .Where(v => v.IdVenta == UltimaFactura.IdVenta)
                .ToList();

            using (var writer = new StreamWriter(tempPath, false, Encoding.UTF8))
            {
                writer.WriteLine("Factura N°;Fecha;Cliente;Total");
                writer.WriteLine($"{UltimaFactura.IdVenta};{UltimaFactura.FechaCompra:dd/MM/yyyy};{ClienteSeleccionado.NombreCliente} {ClienteSeleccionado.ApellidoCliente};{UltimaFactura.TotalVenta}");
                writer.WriteLine();
                writer.WriteLine("Película;Precio;Cantidad;Subtotal");

                foreach (var d in detalles)
                {
                    writer.WriteLine($"{d.IdPeliculaNavigation.NombrePelicula};{d.IdPeliculaNavigation.Precio};{d.Cantidad};{d.IdPeliculaNavigation.Precio * d.Cantidad}");
                }
            }

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("lautarofranciscolezcano@gmail.com");
                mail.To.Add(ClienteSeleccionado.Email);
                mail.Subject = $"Factura #{UltimaFactura.IdVenta}";
                mail.Body = $"Estimado/a {ClienteSeleccionado.NombreCliente},\n\nAdjuntamos su factura #{UltimaFactura.IdVenta}.\n\nSaludos.";
                mail.Attachments.Add(new Attachment(tempPath));

                // Configurar SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("lautarofranciscolezcano@gmail.com", "Lau46381127");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}");
            }
        }
    }
}
