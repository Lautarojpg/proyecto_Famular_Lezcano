namespace proyecto_Famular_Lezcano
{
    partial class UCPeliculas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeliculas.BackgroundColor = Color.White;
            dgvPeliculas.ColumnHeadersHeight = 35;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPeliculas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvPeliculas.Location = new Point(8, 94);
            dgvPeliculas.Margin = new Padding(2);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.RowTemplate.Height = 32;
            dgvPeliculas.Size = new Size(667, 338);
            dgvPeliculas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Categoría";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Precio";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Stock";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(8, 47);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(544, 23);
            txtBuscar.TabIndex = 7;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LTitulo.ForeColor = Color.FromArgb(128, 64, 0);
            LTitulo.Location = new Point(8, 13);
            LTitulo.Margin = new Padding(2, 0, 2, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(259, 30);
            LTitulo.TabIndex = 6;
            LTitulo.Text = "GESTIÓN DE PELÍCULAS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(2, 8);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 75);
            panel1.TabIndex = 8;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BAgregar.ForeColor = Color.White;
            BAgregar.Location = new Point(287, 5);
            BAgregar.Margin = new Padding(2);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(209, 31);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "➕ Agregar Pelicula";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(554, 32);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(107, 41);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "🔍 Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // UCPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(txtBuscar);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Controls.Add(dgvPeliculas);
            Margin = new Padding(2);
            Name = "UCPeliculas";
            Size = new Size(683, 450);
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
