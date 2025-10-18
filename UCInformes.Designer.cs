namespace proyecto_Famular_Lezcano
{
    partial class UCInformes
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
            LHeader = new Label();
            dgvFacturas = new DataGridView();
            DtpDesde = new DateTimePicker();
            DtpHasta = new DateTimePicker();
            BtnLimpiar = new Button();
            BtnFiltrar = new Button();
            LUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            TxtBuscarVendedor = new TextBox();
            BtnBuscarVendedor = new Button();
            BtnBucarCliente = new Button();
            TxtBuscarCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // LHeader
            // 
            LHeader.AutoSize = true;
            LHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LHeader.ForeColor = Color.SaddleBrown;
            LHeader.Location = new Point(18, 15);
            LHeader.Name = "LHeader";
            LHeader.Size = new Size(322, 30);
            LHeader.TabIndex = 0;
            LHeader.Text = "📊 Dashboard Administrativo";
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(18, 278);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.Size = new Size(651, 156);
            dgvFacturas.TabIndex = 1;
            // 
            // DtpDesde
            // 
            DtpDesde.Location = new Point(18, 93);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(200, 23);
            DtpDesde.TabIndex = 2;
            // 
            // DtpHasta
            // 
            DtpHasta.Location = new Point(284, 93);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(200, 23);
            DtpHasta.TabIndex = 3;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.Maroon;
            BtnLimpiar.FlatAppearance.BorderSize = 0;
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(555, 208);
            BtnLimpiar.Margin = new Padding(3, 2, 3, 2);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(114, 30);
            BtnLimpiar.TabIndex = 5;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.BackColor = Color.Maroon;
            BtnFiltrar.FlatAppearance.BorderSize = 0;
            BtnFiltrar.FlatStyle = FlatStyle.Flat;
            BtnFiltrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnFiltrar.ForeColor = Color.White;
            BtnFiltrar.Location = new Point(555, 86);
            BtnFiltrar.Margin = new Padding(3, 2, 3, 2);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(114, 30);
            BtnFiltrar.TabIndex = 6;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrarFecha_Click;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LUsuario.ForeColor = Color.SaddleBrown;
            LUsuario.Location = new Point(79, 71);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(50, 19);
            LUsuario.TabIndex = 7;
            LUsuario.Text = "Desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(359, 71);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 8;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(18, 133);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 9;
            label2.Text = "Vendedor/Gerente";
            // 
            // TxtBuscarVendedor
            // 
            TxtBuscarVendedor.Location = new Point(18, 166);
            TxtBuscarVendedor.Name = "TxtBuscarVendedor";
            TxtBuscarVendedor.Size = new Size(322, 23);
            TxtBuscarVendedor.TabIndex = 10;
            // 
            // BtnBuscarVendedor
            // 
            BtnBuscarVendedor.BackColor = Color.Maroon;
            BtnBuscarVendedor.FlatAppearance.BorderSize = 0;
            BtnBuscarVendedor.FlatStyle = FlatStyle.Flat;
            BtnBuscarVendedor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBuscarVendedor.ForeColor = Color.White;
            BtnBuscarVendedor.Location = new Point(370, 160);
            BtnBuscarVendedor.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            BtnBuscarVendedor.Size = new Size(143, 30);
            BtnBuscarVendedor.TabIndex = 11;
            BtnBuscarVendedor.Text = "Buscar Vendedor";
            BtnBuscarVendedor.UseVisualStyleBackColor = false;
            BtnBuscarVendedor.Click += BtnBuscarVendedor_Click;
            // 
            // BtnBucarCliente
            // 
            BtnBucarCliente.BackColor = Color.Maroon;
            BtnBucarCliente.FlatAppearance.BorderSize = 0;
            BtnBucarCliente.FlatStyle = FlatStyle.Flat;
            BtnBucarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnBucarCliente.ForeColor = Color.White;
            BtnBucarCliente.Location = new Point(370, 209);
            BtnBucarCliente.Margin = new Padding(3, 2, 3, 2);
            BtnBucarCliente.Name = "BtnBucarCliente";
            BtnBucarCliente.Size = new Size(143, 30);
            BtnBucarCliente.TabIndex = 13;
            BtnBucarCliente.Text = "Buscar Cliente";
            BtnBucarCliente.UseVisualStyleBackColor = false;
            BtnBucarCliente.Click += BtnBuscarCliente_Click;
            // 
            // TxtBuscarCliente
            // 
            TxtBuscarCliente.Location = new Point(18, 215);
            TxtBuscarCliente.Name = "TxtBuscarCliente";
            TxtBuscarCliente.Size = new Size(322, 23);
            TxtBuscarCliente.TabIndex = 12;
            // 
            // UCInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(BtnBucarCliente);
            Controls.Add(TxtBuscarCliente);
            Controls.Add(BtnBuscarVendedor);
            Controls.Add(TxtBuscarVendedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LUsuario);
            Controls.Add(BtnFiltrar);
            Controls.Add(BtnLimpiar);
            Controls.Add(DtpHasta);
            Controls.Add(DtpDesde);
            Controls.Add(dgvFacturas);
            Controls.Add(LHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCInformes";
            Size = new Size(683, 450);
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label LHeader;
        private DataGridView dgvFacturas;
        private DateTimePicker DtpDesde;
        private DateTimePicker DtpHasta;
        private Button BtnLimpiar;
        private Button BtnFiltrar;
        private Label LUsuario;
        private Label label1;
        private Label label2;
        private TextBox TxtBuscarVendedor;
        private Button BtnBuscarVendedor;
        public Button BtnBucarCliente;
        public TextBox TxtBuscarCliente;
    }
}
