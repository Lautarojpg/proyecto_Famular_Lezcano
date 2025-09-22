using System;
using System.Linq;
using System.Windows.Forms;
using proyecto_Famular_Lezcano.Models; // Para acceder al DbContext

namespace proyecto_Famular_Lezcano
{
    public partial class FormLogin : Form
    {
        private readonly ProyectoFamularLezcanoContext _context;

        public FormLogin()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TUsuario.Text.Trim();
            string passIngresado = TPassword.Text.Trim();

            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == usuarioIngresado);

            if (usuario != null && BCrypt.Net.BCrypt.Verify(passIngresado, usuario.Contrasena))
            {
                FormMain formMain = new FormMain(usuario.Rol);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

