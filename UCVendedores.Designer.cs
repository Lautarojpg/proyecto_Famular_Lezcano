namespace proyecto_Famular_Lezcano
{
    partial class UCVendedores
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

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVendedores = new DataGridView();
            nombre_vendedor = new DataGridViewTextBoxColumn();
            apellido_vendedor = new DataGridViewTextBoxColumn();
            acronimo_vendedor = new DataGridViewTextBoxColumn();
            email_vendedor = new DataGridViewTextBoxColumn();
            estado_vendedor = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewTextBoxColumn();
            BtnBuscar = new Button();
            BAgregar = new Button();
            panel1 = new Panel();
            LTitulo = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { nombre_vendedor, apellido_vendedor, acronimo_vendedor, email_vendedor, estado_vendedor, acciones });
            dgvVendedores.Location = new Point(3, 195);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(654, 202);
            dgvVendedores.TabIndex = 2;
            // 
            // nombre_vendedor
            // 
            nombre_vendedor.HeaderText = "Nombre";
            nombre_vendedor.MinimumWidth = 6;
            nombre_vendedor.Name = "nombre_vendedor";
            nombre_vendedor.Width = 125;
            // 
            // apellido_vendedor
            // 
            apellido_vendedor.HeaderText = "Apellido";
            apellido_vendedor.MinimumWidth = 6;
            apellido_vendedor.Name = "apellido_vendedor";
            apellido_vendedor.Width = 125;
            // 
            // acronimo_vendedor
            // 
            acronimo_vendedor.HeaderText = "Acronimo";
            acronimo_vendedor.MinimumWidth = 6;
            acronimo_vendedor.Name = "acronimo_vendedor";
            acronimo_vendedor.Width = 125;
            // 
            // email_vendedor
            // 
            email_vendedor.HeaderText = "Email";
            email_vendedor.MinimumWidth = 6;
            email_vendedor.Name = "email_vendedor";
            email_vendedor.Width = 125;
            // 
            // estado_vendedor
            // 
            estado_vendedor.HeaderText = "Estado";
            estado_vendedor.MinimumWidth = 6;
            estado_vendedor.Name = "estado_vendedor";
            estado_vendedor.Width = 125;
            // 
            // acciones
            // 
            acciones.HeaderText = "Acciones";
            acciones.MinimumWidth = 6;
            acciones.Name = "acciones";
            acciones.Width = 125;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(488, 52);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(152, 40);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "Buscar Usuario";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
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
            BAgregar.Text = "Agregar Usuarios";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(3, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 100);
            panel1.TabIndex = 5;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LTitulo.ForeColor = Color.Maroon;
            LTitulo.Location = new Point(14, 52);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(222, 25);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "GESTION DE USUARIOS";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(14, 106);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(307, 23);
            txtBuscar.TabIndex = 4;
            // 
            // UCVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(txtBuscar);
            Controls.Add(dgvVendedores);
            Controls.Add(LTitulo);
            Controls.Add(panel1);
            Name = "UCVendedores";
            Size = new Size(660, 490);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn nombre_vendedor;
        private DataGridViewTextBoxColumn apellido_vendedor;
        private DataGridViewTextBoxColumn acronimo_vendedor;
        private DataGridViewTextBoxColumn email_vendedor;
        private DataGridViewTextBoxColumn estado_vendedor;
        private DataGridViewTextBoxColumn acciones;
        private Button BtnBuscar;
        private Button BAgregar;
        private Panel panel1;
        private Label LTitulo;
        private TextBox txtBuscar;
    }
}
