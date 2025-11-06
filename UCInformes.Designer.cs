namespace proyecto_Famular_Lezcano
{
    partial class UCInformes
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
            btnEstadisticas = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();

            // 
            // LHeader
            // 
            LHeader.AutoSize = true;
            LHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LHeader.ForeColor = Color.Maroon;
            LHeader.Location = new Point(20, 20);
            LHeader.Name = "LHeader";
            LHeader.Size = new Size(370, 37);
            LHeader.TabIndex = 0;
            LHeader.Text = "📊 DASHBOARD ADMINISTRATIVO";

            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.BackgroundColor = Color.White;
            dgvFacturas.ColumnHeadersHeight = 35;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFacturas.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvFacturas.RowTemplate.Height = 30;
            dgvFacturas.Location = new Point(20, 350);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(740, 230);
            dgvFacturas.TabIndex = 1;

            // 
            // DtpDesde
            // 
            DtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            DtpDesde.Font = new Font("Segoe UI", 10F);
            DtpDesde.Location = new Point(20, 110);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(250, 27);
            DtpDesde.TabIndex = 2;

            // 
            // DtpHasta
            // 
            DtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            DtpHasta.Font = new Font("Segoe UI", 10F);
            DtpHasta.Location = new Point(310, 110);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(250, 27);
            DtpHasta.TabIndex = 3;

            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFiltrar.BackColor = Color.FromArgb(128, 64, 0);
            BtnFiltrar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnFiltrar.ForeColor = Color.White;
            BtnFiltrar.Location = new Point(600, 180);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(160, 40);
            BtnFiltrar.TabIndex = 4;
            BtnFiltrar.Text = "🔍 Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrarFecha_Click;

            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLimpiar.BackColor = Color.FromArgb(128, 64, 0);
            BtnLimpiar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(600, 240);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(160, 40);
            BtnLimpiar.TabIndex = 5;
            BtnLimpiar.Text = "🧹 Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;

            // 
            // LUsuario (Desde)
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LUsuario.ForeColor = Color.SaddleBrown;
            LUsuario.Location = new Point(20, 85);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(60, 23);
            LUsuario.Text = "Desde";

            // 
            // label1 (Hasta)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(310, 85);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.Text = "Hasta";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(20, 160);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.Text = "Vendedor/Gerente";

            // 
            // TxtBuscarVendedor
            // 
            TxtBuscarVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarVendedor.Font = new Font("Segoe UI", 10F);
            TxtBuscarVendedor.Location = new Point(20, 185);
            TxtBuscarVendedor.Name = "TxtBuscarVendedor";
            TxtBuscarVendedor.Size = new Size(360, 27);
            TxtBuscarVendedor.TabIndex = 6;

            // 
            // BtnBuscarVendedor
            // 
            BtnBuscarVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BtnBuscarVendedor.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarVendedor.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscarVendedor.ForeColor = Color.White;
            BtnBuscarVendedor.Location = new Point(400, 180);
            BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            BtnBuscarVendedor.Size = new Size(180, 40);
            BtnBuscarVendedor.TabIndex = 7;
            BtnBuscarVendedor.Text = "👤 Buscar Vend.";
            BtnBuscarVendedor.UseVisualStyleBackColor = false;
            BtnBuscarVendedor.Click += BtnBuscarVendedor_Click;

            // 
            // TxtBuscarCliente
            // 
            TxtBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarCliente.Font = new Font("Segoe UI", 10F);
            TxtBuscarCliente.Location = new Point(20, 250);
            TxtBuscarCliente.Name = "TxtBuscarCliente";
            TxtBuscarCliente.Size = new Size(360, 27);
            TxtBuscarCliente.TabIndex = 8;

            // 
            // BtnBucarCliente
            // 
            BtnBucarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BtnBucarCliente.BackColor = Color.FromArgb(128, 64, 0);
            BtnBucarCliente.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBucarCliente.ForeColor = Color.White;
            BtnBucarCliente.Location = new Point(400, 245);
            BtnBucarCliente.Name = "BtnBucarCliente";
            BtnBucarCliente.Size = new Size(180, 40);
            BtnBucarCliente.TabIndex = 9;
            BtnBucarCliente.Text = "🧾 Buscar Cliente";
            BtnBucarCliente.UseVisualStyleBackColor = false;
            BtnBucarCliente.Click += BtnBuscarCliente_Click;

            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstadisticas.BackColor = Color.FromArgb(128, 64, 0);
            btnEstadisticas.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(550, 30);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(210, 40);
            btnEstadisticas.TabIndex = 10;
            btnEstadisticas.Text = "📈 Ver Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;

            // 
            // UCInformes
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(LHeader);
            Controls.Add(DtpDesde);
            Controls.Add(DtpHasta);
            Controls.Add(LUsuario);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(TxtBuscarVendedor);
            Controls.Add(BtnBuscarVendedor);
            Controls.Add(TxtBuscarCliente);
            Controls.Add(BtnBucarCliente);
            Controls.Add(BtnFiltrar);
            Controls.Add(BtnLimpiar);
            Controls.Add(btnEstadisticas);
            Controls.Add(dgvFacturas);
            Name = "UCInformes";
            Size = new Size(781, 600);
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
        private Button btnEstadisticas;
    }
}
