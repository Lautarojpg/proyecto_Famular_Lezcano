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
            DeshabilitarBoton(BtnBackUp);

            // Habilitamos según el rol obtenido de la base de datos
            switch (nombreRol)
            {
                case "Administrador":
                    HabilitarBoton(BClientes);
                    HabilitarBoton(BProductos);
                    HabilitarBoton(BVentas);
                    HabilitarBoton(BVendedores);
                    HabilitarBoton(BInformes);
                    HabilitarBoton(BtnBackUp);
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
            this.FormBorderStyle = FormBorderStyle.Sizable;
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

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir diálogo para elegir dónde guardar el backup
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivo de Backup (*.bak)|*.bak";
                    saveFileDialog.Title = "Guardar copia de seguridad";
                    saveFileDialog.FileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = saveFileDialog.FileName;

                        // Conexión directa a SQL Server (ajustala según tu conexión real)
                        string connectionString = "Server=.\\SQLEXPRESS;Database=proyecto_Famular_Lezcano;Trusted_Connection=True;TrustServerCertificate=True;";

                        using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                        {
                            connection.Open();

                            string backupQuery = $@"
                        BACKUP DATABASE [proyecto_Famular_Lezcano]
                        TO DISK = '{backupPath}'
                        WITH FORMAT, INIT,
                        NAME = 'Backup_{DateTime.Now:yyyyMMdd_HHmmss}',
                        SKIP, NOREWIND, NOUNLOAD, STATS = 10;";

                            using (var command = new Microsoft.Data.SqlClient.SqlCommand(backupQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("✅ Backup realizado correctamente en:\n" + backupPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al realizar el backup:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
