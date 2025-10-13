using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class UCClientes : UserControl
    {
        private readonly ProyectoFamularLezcanoContext _context;

        public UCClientes()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();

            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;

            ConfigurarColumnas();
            CargarClientes();
        }

        private void ConfigurarColumnas()
        {
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NombreCliente"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "ApellidoCliente"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono"
            });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Dirección",
                DataPropertyName = "Direccion"
            });

            // Columna oculta para el IdCliente
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "IdCliente",
                DataPropertyName = "IdCliente",
                Name = "IdCliente",
                Visible = false // Ocultar de la vista del usuario
            });

            // Botones de acción
            var btnEditar = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Editar",
                Name = "btnEditar",
                UseColumnTextForButtonValue = true
            };
            dgvClientes.Columns.Add(btnEditar);

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "btnEliminar",
                UseColumnTextForButtonValue = true
            };
            dgvClientes.Columns.Add(btnEliminar);

            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private void CargarClientes()
        {
            var clientes = _context.Clientes
                .Select(c => new
                {
                    c.IdCliente,
                    c.NombreCliente,
                    c.ApellidoCliente,
                    c.Email,
                    c.Telefono,
                    c.Direccion
                })
                .ToList();

            dgvClientes.DataSource = clientes;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarCliente form = new FormAgregarCliente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    CargarClientes();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int idCliente = (int)dgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value;
            var cliente = _context.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente == null)
                return;

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                using (FormAgregarCliente form = new FormAgregarCliente(cliente))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        CargarClientes();
                }
            }
            else if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirmar = MessageBox.Show("¿Deseas eliminar este cliente?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmar == DialogResult.Yes)
                {
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();
                    CargarClientes();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                CargarClientes();
                return;
            }

            var resultados = _context.Clientes
                .Where(c => EF.Functions.Like(c.NombreCliente, $"%{texto}%") ||
                            EF.Functions.Like(c.ApellidoCliente, $"%{texto}%"))
                .Select(c => new
                {
                    c.IdCliente,
                    c.NombreCliente,
                    c.ApellidoCliente,
                    c.Email,
                    c.Telefono,
                    c.Direccion
                })
                .ToList();

            dgvClientes.DataSource = resultados;
        }
    }
}
