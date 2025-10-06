namespace proyecto_Famular_Lezcano
{
    partial class UCPeliculas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            dgvPeliculas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            BAgregar = new Button();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvPeliculas.Location = new Point(20, 154);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(600, 202);
            dgvPeliculas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Categoría";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Precio";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Stock";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(11, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(307, 23);
            txtBuscar.TabIndex = 7;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LTitulo.ForeColor = Color.Maroon;
            LTitulo.Location = new Point(11, 22);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(225, 25);
            LTitulo.TabIndex = 6;
            LTitulo.Text = "GESTION DE PELICULAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 100);
            panel1.TabIndex = 8;
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BAgregar.ForeColor = Color.White;
            BAgregar.Location = new Point(491, 6);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(152, 40);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "Agregar Pelicula";
            BAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(491, 52);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(152, 40);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "Buscar Pelicula";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // UCPeliculas
            // 
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(txtBuscar);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Controls.Add(dgvPeliculas);
            Name = "UCPeliculas";
            Size = new Size(661, 370);
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvPeliculas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox txtBuscar;
        private Label LTitulo;
        private Panel panel1;
        private Button BAgregar;
        private Button BtnBuscar;
    }
}
