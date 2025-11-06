using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class UCInformes : UserControl
    {
        private ProyectoFamularLezcanoContext _context;

        public UCInformes()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            ConfigurarGrid();
            CargarFacturas();
        }

        private void ConfigurarGrid()
        {
            dgvFacturas.AutoGenerateColumns = false;
            dgvFacturas.Columns.Clear();

            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Venta",
                DataPropertyName = "IdVenta"
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha",
                DataPropertyName = "FechaCompra"
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cliente",
                DataPropertyName = "Cliente"
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Vendedor",
                DataPropertyName = "Vendedor"
            });
            dgvFacturas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total ($)",
                DataPropertyName = "TotalVenta"
            });
        }

        private void CargarFacturas()
        {
            var facturas = _context.VentaCabeceras
                .Select(v => new
                {
                    v.IdVenta,
                    v.FechaCompra,
                    v.TotalVenta,
                    Cliente = v.IdClienteNavigation.NombreCliente + " " + v.IdClienteNavigation.ApellidoCliente,
                    Vendedor = v.VentaDetalles.Any() && v.VentaDetalles.FirstOrDefault().IdUsuario != null
                        ? v.VentaDetalles.FirstOrDefault().IdUsuario.ToString()
                        : "Sin vendedor"
                })
                .OrderByDescending(v => v.FechaCompra)
                .ToList();

            dgvFacturas.DataSource = facturas;
        }

        // 🔍 Buscar por cliente (nombre o apellido)
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string textoCliente = TxtBuscarCliente.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoCliente))
            {
                MessageBox.Show("Ingrese un nombre o apellido de cliente para buscar.");
                return;
            }

            var resultados = _context.VentaCabeceras
                .Where(v =>
                    v.IdClienteNavigation.NombreCliente.ToLower().Contains(textoCliente) ||
                    v.IdClienteNavigation.ApellidoCliente.ToLower().Contains(textoCliente))
                .Select(v => new
                {
                    v.IdVenta,
                    v.FechaCompra,
                    v.TotalVenta,
                    Cliente = v.IdClienteNavigation.NombreCliente + " " + v.IdClienteNavigation.ApellidoCliente,
                    Vendedor = v.VentaDetalles.Any() && v.VentaDetalles.FirstOrDefault().IdUsuario != null
                        ? v.VentaDetalles.FirstOrDefault().IdUsuario.ToString()
                        : "Sin vendedor"
                })
                .OrderByDescending(v => v.FechaCompra)
                .ToList();

            dgvFacturas.DataSource = resultados;
        }

        // Buscar por vendedor (nombre o apellido)
        private void BtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            string textoVendedor = TxtBuscarVendedor.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoVendedor))
            {
                MessageBox.Show("Ingrese un nombre o apellido de vendedor/gerente para buscar.");
                return;
            }

            // No se puede buscar por nombre/apellido de vendedor si no existe la navegación.
            // Solo se puede buscar por IdUsuario.
            if (!int.TryParse(textoVendedor, out int idUsuarioBuscado))
            {
                MessageBox.Show("Ingrese el ID numérico del vendedor para buscar.");
                return;
            }

            var resultados = _context.VentaCabeceras
                .Where(v => v.VentaDetalles.Any(d => d.IdUsuario == idUsuarioBuscado))
                .Select(v => new
                {
                    v.IdVenta,
                    v.FechaCompra,
                    v.TotalVenta,
                    Cliente = v.IdClienteNavigation.NombreCliente + " " + v.IdClienteNavigation.ApellidoCliente,
                    Vendedor = v.VentaDetalles.Any() && v.VentaDetalles.FirstOrDefault().IdUsuario != null
                        ? v.VentaDetalles.FirstOrDefault().IdUsuario.ToString()
                        : "Sin vendedor"
                })
                .OrderByDescending(v => v.FechaCompra)
                .ToList();

            dgvFacturas.DataSource = resultados;
        }

        // Filtrar por rango de fechas
        private void BtnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = DtpDesde.Value.Date;
            DateTime hasta = DtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            var resultados = _context.VentaCabeceras
                .Where(v => v.FechaCompra >= desde && v.FechaCompra <= hasta)
                .Select(v => new
                {
                    v.IdVenta,
                    v.FechaCompra,
                    v.TotalVenta,
                    Cliente = v.IdClienteNavigation.NombreCliente + " " + v.IdClienteNavigation.ApellidoCliente,
                    Vendedor = v.VentaDetalles.Any() && v.VentaDetalles.FirstOrDefault().IdUsuario != null
                        ? v.VentaDetalles.FirstOrDefault().IdUsuario.ToString()
                        : "Sin vendedor"
                })
                .OrderByDescending(v => v.FechaCompra)
                .ToList();

            dgvFacturas.DataSource = resultados;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscarCliente.Clear();
            TxtBuscarVendedor.Clear();
            DtpDesde.Value = DateTime.Today.AddDays(-7);
            DtpHasta.Value = DateTime.Today;
            CargarFacturas();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas form = new FormEstadisticas();
            form.ShowDialog();
        }
    }
}
