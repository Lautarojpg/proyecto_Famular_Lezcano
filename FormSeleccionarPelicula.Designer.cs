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
            dataGridView1 = new DataGridView();
            BtnBuscarPelicula = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            panelSuperior.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(128, 64, 0);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(950, 73);
            panelSuperior.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Bisque;
            lblTitulo.Location = new Point(21, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seleccionar Película";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.Bisque;
            panelContenedor.Controls.Add(dataGridView1);
            panelContenedor.Controls.Add(BtnBuscarPelicula);
            panelContenedor.Controls.Add(lblBuscar);
            panelContenedor.Controls.Add(txtBuscar);
            panelContenedor.Controls.Add(btnBuscar);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 73);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Padding = new Padding(21, 20, 21, 20);
            panelContenedor.Size = new Size(950, 527);
            panelContenedor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 76);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(913, 440);
            dataGridView1.TabIndex = 5;
            // 
            // BtnBuscarPelicula
            // 
            BtnBuscarPelicula.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscarPelicula.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarPelicula.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnBuscarPelicula.ForeColor = Color.White;
            BtnBuscarPelicula.Location = new Point(805, 5);
            BtnBuscarPelicula.Margin = new Padding(2, 3, 2, 3);
            BtnBuscarPelicula.Name = "BtnBuscarPelicula";
            BtnBuscarPelicula.Size = new Size(122, 63);
            BtnBuscarPelicula.TabIndex = 4;
            BtnBuscarPelicula.Text = "🔍 Buscar";
            BtnBuscarPelicula.UseVisualStyleBackColor = false;
            BtnBuscarPelicula.Click += BtnBuscarPelicula_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.Maroon;
            lblBuscar.Location = new Point(21, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(151, 28);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar Película:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Location = new Point(214, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(577, 32);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Maroon;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Bisque;
            btnBuscar.Location = new Point(1499, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 32);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private Panel panelContenedor;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button BtnBuscarPelicula;
        private DataGridView dataGridView1;
    }
}
