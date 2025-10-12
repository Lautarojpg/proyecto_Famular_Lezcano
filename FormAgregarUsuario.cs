using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarUsuario : Form
    {
        public Usuario? NuevoUsuario { get; private set; }
        private bool _esEdicion = false;
        private string? _passwordActual;

        public FormAgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        public FormAgregarUsuario(Usuario usuarioExistente) : this()
        {
            CargarUsuario(usuarioExistente);
        }

        // 🔹 Carga los roles disponibles desde la BD
        private void CargarRoles()
        {
            using (var db = new ProyectoFamularLezcanoContext())
            {
                var roles = db.Rols.ToList();
                CbRol.DataSource = roles;
                CbRol.DisplayMember = "NombreRol"; // nombre_rol en BD → propiedad generada: NombreRol
                CbRol.ValueMember = "IdRol";       // id_rol en BD → propiedad generada: IdRol
                CbRol.SelectedIndex = -1;          // sin seleccionar al principio
            }
        }

        // 🔹 Carga los datos del usuario para editar
        public void CargarUsuario(Usuario usuario)
        {
            _esEdicion = true;
            NuevoUsuario = usuario;

            TNombre.Text = usuario.Nombre;
            TApellido.Text = usuario.Apellido;
            TNomUsuario.Text = usuario.NombreUsuario;
            TEmail.Text = usuario.Email;
            _passwordActual = usuario.Contrasena;

            // selecciona el rol actual
            CbRol.SelectedValue = usuario.IdRol;
        }

        // 🔹 Botón para agregar o editar usuario
        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Campos obligatorios
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNomUsuario.Text) ||
                string.IsNullOrWhiteSpace(TEmail.Text) ||
                CbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios (incluido el rol).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar nombre y apellido solo letras y espacios
            Regex regexNombre = new Regex(@"^[a-zA-Z\s]+$");
            if (!regexNombre.IsMatch(TNombre.Text) || !regexNombre.IsMatch(TApellido.Text))
            {
                MessageBox.Show("Nombre y apellido solo pueden contener letras y espacios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar email
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!regexEmail.IsMatch(TEmail.Text))
            {
                MessageBox.Show("Ingrese un email válido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idRolSeleccionado = Convert.ToInt32(CbRol.SelectedValue);

            // Validar contraseña solo si es nuevo usuario o se cambió la contraseña
            string hashedPassword;
            if (_esEdicion)
            {
                if (!string.IsNullOrWhiteSpace(TContraseña.Text))
                {
                    if (!ValidarContraseña(TContraseña.Text)) return;
                    hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContraseña.Text);
                }
                else
                {
                    hashedPassword = _passwordActual ?? "";
                }

                NuevoUsuario!.Nombre = TNombre.Text;
                NuevoUsuario.Apellido = TApellido.Text;
                NuevoUsuario.NombreUsuario = TNomUsuario.Text;
                NuevoUsuario.Contrasena = hashedPassword;
                NuevoUsuario.Email = TEmail.Text;
                NuevoUsuario.IdRol = idRolSeleccionado;
            }
            else
            {
                if (!ValidarContraseña(TContraseña.Text)) return;

                hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContraseña.Text);
                NuevoUsuario = new Usuario
                {
                    Nombre = TNombre.Text,
                    Apellido = TApellido.Text,
                    NombreUsuario = TNomUsuario.Text,
                    Contrasena = hashedPassword,
                    Email = TEmail.Text,
                    IdRol = idRolSeleccionado,
                    Estado = true
                };
            }

            // Guardar en base de datos
            using (var db = new ProyectoFamularLezcanoContext())
            {
                // Validar duplicados
                if (_esEdicion)
                {
                    if (db.Usuarios.Any(u => u.NombreUsuario == NuevoUsuario!.NombreUsuario && u.IdUsuario != NuevoUsuario.IdUsuario))
                    {
                        MessageBox.Show("El nombre de usuario ya existe. Elija otro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (db.Usuarios.Any(u => u.Email == NuevoUsuario.Email && u.IdUsuario != NuevoUsuario.IdUsuario))
                    {
                        MessageBox.Show("El email ya está registrado. Elija otro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.Usuarios.Update(NuevoUsuario!);
                }
                else
                {
                    if (db.Usuarios.Any(u => u.NombreUsuario == NuevoUsuario!.NombreUsuario))
                    {
                        MessageBox.Show("El nombre de usuario ya existe. Elija otro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (db.Usuarios.Any(u => u.Email == NuevoUsuario.Email))
                    {
                        MessageBox.Show("El email ya está registrado. Elija otro.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    db.Usuarios.Add(NuevoUsuario!);
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // 🔹 Validación de contraseña
        private bool ValidarContraseña(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La contraseña es obligatoria", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra minúscula", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("La contraseña debe contener al menos un número", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
