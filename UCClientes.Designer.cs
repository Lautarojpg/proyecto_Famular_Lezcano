namespace proyecto_Famular_Lezcano
{
    partial class UCClientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            txtBuscar = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            BAgregar = new Button();
            BtnBuscar = new Button();
            dgvClientes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(11, 76);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(307, 23);
            txtBuscar.TabIndex = 11;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LTitulo.ForeColor = Color.Maroon;
            LTitulo.Location = new Point(11, 22);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(212, 25);
            LTitulo.TabIndex = 10;
            LTitulo.Text = "GESTION DE CLIENTES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 100);
            panel1.TabIndex = 12;
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
            BAgregar.Text = "Agregar Cliente";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
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
            BtnBuscar.Text = "Buscar Cliente";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvClientes.Location = new Point(20, 154);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(600, 202);
            dgvClientes.TabIndex = 9;
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
            // UCClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtBuscar);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCClientes";
            Size = new Size(666, 375);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label LTitulo;
        private Panel panel1;
        private Button BAgregar;
        private Button BtnBuscar;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}



