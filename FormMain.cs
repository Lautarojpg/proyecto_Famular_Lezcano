namespace proyecto_Famular_Lezcano
{
    public partial class FormMain : Form
    {
        private string rolUsuario;
        public FormMain(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
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
            AbrirUserControl(new UCProductos());
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
            // Primero deshabilitamos todo
            DeshabilitarBoton(BClientes);
            DeshabilitarBoton(BProductos);
            DeshabilitarBoton(BVentas);
            DeshabilitarBoton(BVendedores);
            DeshabilitarBoton(BInformes);

            // Luego habilitamos según el rol
            switch (rolUsuario)
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
            }
        }

        private void HabilitarBoton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.Maroon; // 👈 tu color normal (rojo oscuro)
            btn.ForeColor = Color.White;  // texto blanco
        }

        private void DeshabilitarBoton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Gray;   // 👈 color grisado para deshabilitado
            btn.ForeColor = Color.DarkGray;
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void BProductos_Click_1(object sender, EventArgs e)
        {

        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

