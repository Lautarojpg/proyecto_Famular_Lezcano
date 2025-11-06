namespace proyecto_Famular_Lezcano
{
    partial class UCVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvVendedores = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            BAgregar = new Button();
            BtnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedores.BackgroundColor = Color.White;
            dgvVendedores.ColumnHeadersHeight = 35;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellido, colDni, colTelefono });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVendedores.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVendedores.Location = new Point(9, 126);
            dgvVendedores.Margin = new Padding(2);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.RowTemplate.Height = 32;
            dgvVendedores.Size = new Size(762, 450);
            dgvVendedores.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.MinimumWidth = 6;
            colDni.Name = "colDni";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Location = new Point(9, 63);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(621, 27);
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
            LTitulo.Size = new Size(361, 37);
            LTitulo.TabIndex = 6;
            LTitulo.Text = "GESTIÓN DE VENDEDORES";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(2, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 100);
            panel1.TabIndex = 8;
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BAgregar.ForeColor = Color.White;
            BAgregar.Location = new Point(642, 6);
            BAgregar.Margin = new Padding(2);
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
            BtnBuscar.Location = new Point(642, 52);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(122, 33);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "🔍 Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // UCVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(txtBuscar);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Controls.Add(dgvVendedores);
            Margin = new Padding(2);
            Name = "UCVendedores";
            Size = new Size(781, 600);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colTelefono;
        private TextBox txtBuscar;
        private Label LTitulo;
        private Panel panel1;
        private Button BAgregar;
        private Button BtnBuscar;
    }
}
