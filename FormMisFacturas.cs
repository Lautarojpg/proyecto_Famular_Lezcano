using proyecto_Famular_Lezcano.Helpers;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormMisFacturas : Form
    {
        private ProyectoFamularLezcanoContext _context;

        public FormMisFacturas()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            int idUsuario = SesionActual.Usuario.IdUsuario;

            var facturas = _context.VentaCabeceras
                .Where(vc => vc.VentaDetalles.Any(vd => vd.IdUsuario == idUsuario))
                .Select(vc => new
                {
                    vc.IdVenta,
                    vc.FechaCompra,
                    Cliente = vc.IdClienteNavigation.NombreCliente + " " + vc.IdClienteNavigation.ApellidoCliente,
                    vc.TotalVenta
                })
                .ToList();

            dgvFacturas.DataSource = facturas;

            // Agregar el botón de anular solo si no existe ya
            if (!dgvFacturas.Columns.Contains("BtnAnular"))
            {
                DataGridViewButtonColumn btnAnular = new DataGridViewButtonColumn();
                btnAnular.Name = "BtnAnular";
                btnAnular.HeaderText = "Acción";
                btnAnular.Text = "Anular";
                btnAnular.UseColumnTextForButtonValue = true;
                dgvFacturas.Columns.Add(btnAnular);
            }
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Verifica si se hizo clic en el botón de anular
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "BtnAnular")
            {
                int idVenta = (int)dgvFacturas.Rows[e.RowIndex].Cells["IdVenta"].Value;
                AnularFactura(idVenta);
            }
        }

        private void AnularFactura(int idVenta)
        {
            var ventaOriginal = _context.VentaCabeceras
                .FirstOrDefault(v => v.IdVenta == idVenta);

            if (ventaOriginal == null)
            {
                MessageBox.Show("No se encontró la factura seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar acción
            if (MessageBox.Show("¿Está seguro que desea anular esta factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // Crear la contrafactura (cabecera)
            var contraFactura = new VentaCabecera
            {
                FechaCompra = DateTime.Now,
                IdCliente = ventaOriginal.IdCliente,
                TotalVenta = -ventaOriginal.TotalVenta, // monto negativo
            };
            _context.VentaCabeceras.Add(contraFactura);
            _context.SaveChanges();

            // Obtener los detalles originales
            var detallesOriginales = _context.VentaDetalles
                .Where(d => d.IdVenta == idVenta)
                .ToList();

            foreach (var detalleOriginal in detallesOriginales)
            {
                // Crear detalle inverso (contrafactura)
                var detalleContra = new VentaDetalle
                {
                    IdVenta = contraFactura.IdVenta,
                    IdPelicula = detalleOriginal.IdPelicula,
                    Cantidad = detalleOriginal.Cantidad,
                    IdUsuario = SesionActual.Usuario.IdUsuario
                };
                _context.VentaDetalles.Add(detalleContra);

                // Devolver stock
                var pelicula = _context.Peliculas.FirstOrDefault(p => p.IdPelicula == detalleOriginal.IdPelicula);
                if (pelicula != null)
                {
                    pelicula.Stock += detalleOriginal.Cantidad;
                }
            }

            _context.SaveChanges();

            MessageBox.Show("Factura anulada correctamente. Se generó la contrafactura y se devolvió el stock.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refrescar la grilla
            CargarFacturas();
        }

        private void dgvFacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFacturas.Columns[e.ColumnIndex].Name == "TotalVenta" && e.Value is decimal total && total < 0)
            {
                dgvFacturas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }
    }
}
