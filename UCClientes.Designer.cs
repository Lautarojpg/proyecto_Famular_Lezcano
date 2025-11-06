namespace proyecto_Famular_Lezcano
{
    partial class UCClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            BAgregar = new Button();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeight = 35;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colNombre, colCorreo, colTelefono, colDireccion });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Location = new Point(9, 126);
            dgvClientes.Margin = new Padding(2, 2, 2, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 32;
            dgvClientes.Size = new Size(606, 350);
            dgvClientes.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(9, 63);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(465, 27);
            txtBuscar.TabIndex = 7;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LTitulo.ForeColor = Color.Maroon;
            LTitulo.Location = new Point(9, 17);
            LTitulo.Margin = new Padding(2, 0, 2, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(299, 37);
            LTitulo.TabIndex = 6;
            LTitulo.Text = "GESTIÓN DE CLIENTES";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(2, 11);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 100);
            panel1.TabIndex = 8;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BAgregar.ForeColor = Color.White;
            BAgregar.Location = new Point(491, 6);
            BAgregar.Margin = new Padding(2, 2, 2, 2);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(122, 33);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "➕ Agregar";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(486, 52);
            BtnBuscar.Margin = new Padding(2, 2, 2, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(122, 33);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "🔍 Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(txtBuscar);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Controls.Add(dgvClientes);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCClientes";
            Size = new Size(625, 500);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colDireccion;
        private TextBox txtBuscar;
        private Label LTitulo;
        private Panel panel1;
        private Button BAgregar;
        private Button BtnBuscar;
    }
}
