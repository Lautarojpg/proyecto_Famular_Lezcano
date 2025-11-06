using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Helpers;
using proyecto_Famular_Lezcano.Models;

namespace proyecto_Famular_Lezcano
{
    public partial class FormLogin : Form
    {
        private readonly ProyectoFamularLezcanoContext _context;

        public FormLogin()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TUsuario.Text.Trim();
            string passIngresado = TPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(passIngresado))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ============================
                // 1️⃣ Buscar en tabla Usuarios
                // ============================
                var usuario = _context.Usuarios
                    .Include(u => u.IdRolNavigation)
                    .FirstOrDefault(u => u.NombreUsuario == usuarioIngresado);

                if (usuario != null)
                {
                    if (!(usuario.Estado ?? false))
                    {
                        MessageBox.Show("Este usuario está deshabilitado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (BCrypt.Net.BCrypt.Verify(passIngresado, usuario.Contrasena))
                    {
                        string nombreRol = usuario.IdRolNavigation?.NombreRol ?? "Sin Rol";
                        SesionActual.Usuario = usuario;

                        MessageBox.Show($"Bienvenido, {usuario.Nombre} ({nombreRol})", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FormMain formMain = new FormMain(nombreRol);
                        formMain.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // ===================================
                // 2️⃣ Si no se encontró, buscar Cliente
                // ===================================
                var cliente = _context.Clientes.FirstOrDefault(c => c.Email == usuarioIngresado);

                if (cliente == null)
                {
                    MessageBox.Show("Usuario o cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BCrypt.Net.BCrypt.Verify(passIngresado, cliente.ContrasenaCliente))
                {
                    SesionActual.Cliente = cliente;

                    MessageBox.Show($"Bienvenido, {cliente.NombreCliente} (Cliente)", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMain formMain = new FormMain("Cliente");
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void FormLogin_Load(object sender, EventArgs e)
        {
            TUsuario.Focus();
        }
    }
}
