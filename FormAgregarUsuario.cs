using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarUsuario : Form
    {
        public Usuario? NuevoUsuario { get; private set; }
        private bool _esEdicion = false;
        private string? _passwordActual; // 👈 guardamos la pass hash si no se cambia
        private string rol;

        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        // 👇 Constructor alternativo para edición
        public FormAgregarUsuario(Usuario usuarioExistente) : this()
        {
            CargarUsuario(usuarioExistente);
        }

        // 👇 Método para precargar datos en edición
        public void CargarUsuario(Usuario usuario)
        {
            _esEdicion = true;
            NuevoUsuario = usuario;

            TNombre.Text = usuario.Nombre;
            TApellido.Text = usuario.Apellido;
            TNomUsuario.Text = usuario.NombreUsuario;
            TEmail.Text = usuario.Email;
            _passwordActual = usuario.Contrasena;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNomUsuario.Text) ||
                string.IsNullOrWhiteSpace(TEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar hash de la contraseña
            string hashedPassword;
            if (_esEdicion)
            {
                // Si el usuario cambió la contraseña
                if (!string.IsNullOrWhiteSpace(TContraseña.Text))
                {
                    hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContraseña.Text);
                }
                else
                {
                    hashedPassword = _passwordActual ?? "";
                }

                // Actualizar el objeto existente
                NuevoUsuario!.Nombre = TNombre.Text;
                NuevoUsuario.Apellido = TApellido.Text;
                NuevoUsuario.NombreUsuario = TNomUsuario.Text;
                NuevoUsuario.Contrasena = hashedPassword;
                NuevoUsuario.Email = TEmail.Text;
                NuevoUsuario.Rol = rol; // o permitir editar el rol si querés
            }
            else
            {
                // Crear nuevo usuario
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContraseña.Text);

                NuevoUsuario = new Usuario
                {
                    Nombre = TNombre.Text,
                    Apellido = TApellido.Text,
                    NombreUsuario = TNomUsuario.Text,
                    Contrasena = hashedPassword,
                    Email = TEmail.Text,
                    Rol = rol,
                };
            }

            // Guardar en la base de datos
            using (var db = new ProyectoFamularLezcanoContext())
            {
                if (_esEdicion)
                {
                    db.Usuarios.Update(NuevoUsuario!);
                }
                else
                {
                    db.Usuarios.Add(NuevoUsuario!);
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            rol = "Vendedor";
        }

        private void rbGerente_CheckedChanged(object sender, EventArgs e)
        {
            rol = "Gerente";
        }

        private void rbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            rol = "Administrador";
        }
    }
}
