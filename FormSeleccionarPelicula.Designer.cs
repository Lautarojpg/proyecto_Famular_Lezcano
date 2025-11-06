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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(128, 64, 0);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(950, 60);
            panelSuperior.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Bisque;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seleccionar Película";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Bisque;
            panelContenedor.Controls.Add(lblBuscar);
            panelContenedor.Controls.Add(txtBuscar);
            panelContenedor.Controls.Add(btnBuscar);
            panelContenedor.Controls.Add(dgvPeliculas);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 60);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(20);
            panelContenedor.Size = new Size(950, 540);
            panelContenedor.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Maroon;
            lblBuscar.Location = new Point(20, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(151, 28);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar Película:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(170, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(1310, 32);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Maroon;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Bisque;
            btnBuscar.Location = new Point(1500, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeliculas.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvPeliculas.BorderStyle = BorderStyle.None;
            dgvPeliculas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeliculas.ColumnHeadersHeight = 35;
            dgvPeliculas.EnableHeadersVisualStyles = false;
            dgvPeliculas.GridColor = Color.Maroon;
            dgvPeliculas.Location = new Point(20, 70);
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersVisible = false;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.RowTemplate.Height = 28;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.Size = new Size(1630, 910);
            dgvPeliculas.TabIndex = 3;
            // 
            // FormSeleccionarPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(950, 600);
            Controls.Add(panelContenedor);
            Controls.Add(panelSuperior);
            Name = "FormSeleccionarPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar Película";
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
