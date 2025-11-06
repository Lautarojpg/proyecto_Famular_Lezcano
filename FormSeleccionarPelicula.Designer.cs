namespace proyecto_Famular_Lezcano
{
    partial class FormSeleccionarPelicula
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            lblTitulo = new Label();
            panelContenedor = new Panel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvPeliculas = new DataGridView();

            panelSuperior.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();

            // 
            // FormSeleccionarPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(950, 600);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar Película";

            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Maroon;
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Height = 60;
            panelSuperior.Controls.Add(lblTitulo);

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Bisque;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Text = "Seleccionar Película";

            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Bisque;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Padding = new Padding(20);
            panelContenedor.Controls.Add(lblBuscar);
            panelContenedor.Controls.Add(txtBuscar);
            panelContenedor.Controls.Add(btnBuscar);
            panelContenedor.Controls.Add(dgvPeliculas);

            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.Maroon;
            lblBuscar.Location = new Point(20, 20);
            lblBuscar.Text = "Buscar Película:";

            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(170, 18);
            txtBuscar.Size = new Size(560, 27);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Maroon;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Bisque;
            btnBuscar.Location = new Point(750, 16);
            btnBuscar.Size = new Size(150, 32);
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvPeliculas.BorderStyle = BorderStyle.None;
            dgvPeliculas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPeliculas.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.Maroon,
                ForeColor = Color.Bisque,
                Font = new Font("Yu Gothic UI", 10F, FontStyle.Bold),
                WrapMode = DataGridViewTriState.True
            };
            dgvPeliculas.ColumnHeadersHeight = 35;
            dgvPeliculas.EnableHeadersVisualStyles = false;
            dgvPeliculas.GridColor = Color.Maroon;
            dgvPeliculas.Location = new Point(20, 70);
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersVisible = false;
            dgvPeliculas.RowTemplate.Height = 28;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.Size = new Size(880, 470);
            dgvPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeliculas.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(255, 192, 128),
                SelectionForeColor = Color.Black
            };
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // 🔸 columnas ajustables

            // 
            // Ensamblar todo
            // 
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);

            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private Panel panelContenedor;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvPeliculas;
    }
}
