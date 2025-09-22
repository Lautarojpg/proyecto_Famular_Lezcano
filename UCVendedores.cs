using proyecto_Famular_Lezcano.Models; // para acceder al DbContext y Usuario
using System;
using System.ComponentModel;
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

            // Justo después de InitializeComponent()
            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.AllowUserToOrderColumns = false;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.MultiSelect = false;

            _context = new ProyectoFamularLezcanoContext();

            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.Columns.Clear();

            // Agrego columnas en el orden correcto
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
                DataPropertyName = "NombreUsuario"   //  propiedad real
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Password (Hash)",
                DataPropertyName = "Contrasena"      //  guardamos hash
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "Rol"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Eliminado",
                DataPropertyName = "Estado"
            });

            // 🔹 Botón Modificar
            var btnModificar = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Modificar",
                Name = "btnModificar",
                UseColumnTextForButtonValue = true
            };
            dgvVendedores.Columns.Add(btnModificar);

            // 🔹 Botón Eliminar
            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "btnEliminar",
                UseColumnTextForButtonValue = true
            };
            dgvVendedores.Columns.Add(btnEliminar);

            dgvVendedores.CellClick += dgvVendedores_CellClick;

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvVendedores.DataSource = _context.Usuarios.ToList();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarUsuario form = new FormAgregarUsuario())
            {
                if (form.ShowDialog() == DialogResult.OK && form.NuevoUsuario != null)
                {

                    form.NuevoUsuario.IdUsuario = 0; // dejar que SQL genere el ID

                    _context.Usuarios.Add(form.NuevoUsuario);
                    _context.SaveChanges();
                    CargarUsuarios();
                }
            }
        }



        // 🔹 Evento para botones en el DataGridView
        private void dgvVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var usuario = (Usuario)dgvVendedores.Rows[e.RowIndex].DataBoundItem;

                if (dgvVendedores.Columns[e.ColumnIndex].Name == "btnModificar")
                {
                    // Abrir el formulario de edición
                    using (FormAgregarUsuario form = new FormAgregarUsuario())
                    {
                        // 👇 Rellenar campos con los datos actuales
                        form.CargarUsuario(usuario);

                        if (form.ShowDialog() == DialogResult.OK && form.NuevoUsuario != null)
                        {
                            // Actualizar usuario existente
                            usuario.Nombre = form.NuevoUsuario.Nombre;
                            usuario.Apellido = form.NuevoUsuario.Apellido;
                            usuario.NombreUsuario = form.NuevoUsuario.NombreUsuario;
                            usuario.Contrasena = form.NuevoUsuario.Contrasena;
                            usuario.Email = form.NuevoUsuario.Email;
                            usuario.Rol = form.NuevoUsuario.Rol;
                            usuario.Estado = 0;

                            _context.Usuarios.Update(usuario);
                            _context.SaveChanges();
                            CargarUsuarios();
                        }
                    }
                }
                else if (dgvVendedores.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    var result = MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                                                 "Confirmación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        usuario.Estado = 1;
                        _context.SaveChanges();
                        CargarUsuarios();
                    }
                }
            }
        }
    }
}
