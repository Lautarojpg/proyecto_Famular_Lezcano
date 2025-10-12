using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormMain : Form
    {
        private string nombreRol;

        public FormMain(string rolNombre)
        {
            InitializeComponent();
            nombreRol = rolNombre;
        }

        private void AbrirUserControl(UserControl uc)
        {
            PanelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new UCClientes());
        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new UCPeliculas());
        }

        private void BVentas_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new UCVentas());
        }

        private void BVendedores_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new UCVendedores());
        }

        private void BInformes_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new UCInformes());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Deshabilitamos todos los botones al inicio
            DeshabilitarBoton(BClientes);
            DeshabilitarBoton(BProductos);
            DeshabilitarBoton(BVentas);
            DeshabilitarBoton(BVendedores);
            DeshabilitarBoton(BInformes);

            // Habilitamos según el rol obtenido de la base de datos
            switch (nombreRol)
            {
                case "Administrador":
                    HabilitarBoton(BClientes);
                    HabilitarBoton(BProductos);
                    HabilitarBoton(BVentas);
                    HabilitarBoton(BVendedores);
                    HabilitarBoton(BInformes);
                    break;

                case "Gerente":
                    HabilitarBoton(BProductos);
                    HabilitarBoton(BVendedores);
                    HabilitarBoton(BInformes);
                    break;

                case "Vendedor":
                    HabilitarBoton(BVentas);
                    HabilitarBoton(BClientes);
                    break;

                default:
                    MessageBox.Show($"Rol desconocido: {nombreRol}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void HabilitarBoton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.Maroon;
            btn.ForeColor = Color.White;
        }

        private void DeshabilitarBoton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Gray;
            btn.ForeColor = Color.DarkGray;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
