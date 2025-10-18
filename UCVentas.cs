using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class UCVentas : UserControl
    {
        private ProyectoFamularLezcanoContext _context;
        private List<DetalleTemp> _detallesTemp = new List<DetalleTemp>();

        public UCVentas()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            CargarClientes();
            CargarPeliculas();
            ConfigurarGrillaDetalle();
        }

        private void CargarClientes()
        {
            CbCliente.DataSource = _context.Clientes.ToList();
            CbCliente.DisplayMember = "NombreCliente";
            CbCliente.ValueMember = "IdCliente";
        }

        private void CargarPeliculas()
        {
            CbPeliculas.DataSource = _context.Peliculas.ToList();
            CbPeliculas.DisplayMember = "NombrePelicula";
            CbPeliculas.ValueMember = "IdPelicula";
        }

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
            if (CbPeliculas.SelectedItem == null) return;

            var pelicula = (Pelicula)CbPeliculas.SelectedItem;
            int cantidad = (int)numCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            decimal subtotal = pelicula.Precio * cantidad;

            _detallesTemp.Add(new DetalleTemp
            {
                IdPelicula = pelicula.IdPelicula,
                NombrePelicula = pelicula.NombrePelicula,
                Precio = pelicula.Precio,
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

        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (CbCliente.SelectedItem == null || !_detallesTemp.Any())
            {
                MessageBox.Show("Debe seleccionar un cliente y agregar al menos una película.");
                return;
            }

            var cliente = (Cliente)CbCliente.SelectedItem;

            var nuevaCabecera = new VentaCabecera
            {
                FechaCompra = DateTime.Now,
                IdCliente = cliente.IdCliente,
                TotalVenta = _detallesTemp.Sum(x => x.Subtotal)
            };

            _context.VentaCabeceras.Add(nuevaCabecera);
            _context.SaveChanges();

            foreach (var d in _detallesTemp)
            {
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
            MessageBox.Show("Factura registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _detallesTemp.Clear();
            RefrescarGrilla();
        }

        private class DetalleTemp
        {
            public int IdPelicula { get; set; }
            public string NombrePelicula { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
        }
    }
}
