using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class UCVendedores : UserControl
    {
        private ProyectoFamularLezcanoContext _context;

        public UCVendedores()
        {
            InitializeComponent();

            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.AllowUserToOrderColumns = false;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.MultiSelect = false;

            _context = new ProyectoFamularLezcanoContext();

            ConfigurarColumnas();
            CargarUsuarios();
        }

        private void ConfigurarColumnas()
        {
            dgvVendedores.Columns.Clear();

            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "Apellido"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "NombreRol" // 👈 propiedad del objeto anónimo
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Activo",
                DataPropertyName = "Activo"
            });

            var btnModificar = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Modificar",
                Name = "btnModificar",
                UseColumnTextForButtonValue = true
            };
            dgvVendedores.Columns.Add(btnModificar);

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "btnEliminar",
                UseColumnTextForButtonValue = true
            };
            dgvVendedores.Columns.Add(btnEliminar);

            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "IdUsuario",
                DataPropertyName = "IdUsuario",
                Name = "IdUsuario",
                Visible = false // hide from UI
            });

            dgvVendedores.CellClick += dgvVendedores_CellClick;
            dgvVendedores.CellFormatting += dgvVendedores_CellFormatting;
        }

        private void CargarUsuarios()
        {
            // Incluye el rol y crea un objeto con el nombre del rol
            var usuarios = _context.Usuarios
                .Include(u => u.IdRolNavigation)
                .Select(u => new
                {
                    u.IdUsuario,
                    u.Nombre,
                    u.Apellido,
                    u.NombreUsuario,
                    u.Email,
                    NombreRol = u.IdRolNavigation.NombreRol, // 👈 columna mostrada
                    Activo = u.Estado
                })
                .ToList();

            dgvVendedores.DataSource = usuarios;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarUsuario form = new FormAgregarUsuario())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
        }

        private void dgvVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Obtenemos el ID del usuario de la fila seleccionada
            int idUsuario = Convert.ToInt32(dgvVendedores.Rows[e.RowIndex].Cells["IdUsuario"].Value);
            var usuario = _context.Usuarios.Include(u => u.IdRolNavigation)
                                           .FirstOrDefault(u => u.IdUsuario == idUsuario);

            if (usuario == null)
                return;

            if (dgvVendedores.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                using (FormAgregarUsuario form = new FormAgregarUsuario())
                {
                    form.CargarUsuario(usuario);

                    if (form.ShowDialog() == DialogResult.OK && form.NuevoUsuario != null)
                    {
                        usuario.Nombre = form.NuevoUsuario.Nombre;
                        usuario.Apellido = form.NuevoUsuario.Apellido;
                        usuario.NombreUsuario = form.NuevoUsuario.NombreUsuario;
                        usuario.Email = form.NuevoUsuario.Email;
                        usuario.Contrasena = form.NuevoUsuario.Contrasena;
                        usuario.IdRol = form.NuevoUsuario.IdRol;
                        usuario.Estado = form.NuevoUsuario.Estado;

                        _context.Usuarios.Update(usuario);
                        _context.SaveChanges();
                        CargarUsuarios();
                    }
                }
            }
            else if (dgvVendedores.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                                              "Confirmación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    usuario.Estado = false;
                    _context.SaveChanges();
                    CargarUsuarios();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                MessageBox.Show("Ingrese un nombre de usuario para buscar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultados = _context.Usuarios
                .Include(u => u.IdRolNavigation)
                .Where(u => EF.Functions.Like(u.NombreUsuario, $"%{textoBusqueda}%"))
                .Select(u => new
                {
                    u.IdUsuario,
                    u.Nombre,
                    u.Apellido,
                    u.NombreUsuario,
                    u.Email,
                    NombreRol = u.IdRolNavigation.NombreRol,
                    Activo = u.Estado
                })
                .ToList();

            if (resultados.Any())
                dgvVendedores.DataSource = resultados;
            else
            {
                MessageBox.Show("No se encontraron usuarios con ese nombre.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvVendedores.DataSource = null;
            }
        }

        private void dgvVendedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVendedores.Columns[e.ColumnIndex].DataPropertyName == "Activo" && e.Value != null)
            {
                bool estado = Convert.ToBoolean(e.Value);
                e.Value = estado ? "Sí" : "No";
                e.FormattingApplied = true;
            }
        }

        private void UCVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
