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
            // Limpia el panel derecho antes de cargar otro
            PanelContent.Controls.Clear();

            // Configura el UserControl para que ocupe todo el panel
            uc.Dock = DockStyle.Fill;

            // Agrega el nuevo UserControl
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

        }
    }
}
