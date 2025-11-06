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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            LHeader.ForeColor = Color.FromArgb(128, 64, 0);
            LHeader.Location = new Point(16, 17);
            LHeader.Margin = new Padding(2, 0, 2, 0);
            LHeader.Name = "LHeader";
            LHeader.Size = new Size(471, 37);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvFacturas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvFacturas.Location = new Point(16, 292);
            dgvFacturas.Margin = new Padding(2, 2, 2, 2);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.RowTemplate.Height = 30;
            dgvFacturas.Size = new Size(592, 192);
            dgvFacturas.TabIndex = 1;
            // 
            // DtpDesde
            // 
            DtpDesde.Font = new Font("Segoe UI", 10F);
            DtpDesde.Location = new Point(16, 92);
            DtpDesde.Margin = new Padding(2, 2, 2, 2);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(201, 30);
            DtpDesde.TabIndex = 2;
            // 
            // DtpHasta
            // 
            DtpHasta.Font = new Font("Segoe UI", 10F);
            DtpHasta.Location = new Point(248, 92);
            DtpHasta.Margin = new Padding(2, 2, 2, 2);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(201, 30);
            DtpHasta.TabIndex = 3;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLimpiar.BackColor = Color.FromArgb(128, 64, 0);
            BtnLimpiar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnLimpiar.ForeColor = Color.White;
            BtnLimpiar.Location = new Point(480, 200);
            BtnLimpiar.Margin = new Padding(2, 2, 2, 2);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(128, 33);
            BtnLimpiar.TabIndex = 5;
            BtnLimpiar.Text = "\U0001f9f9 Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnFiltrar.BackColor = Color.FromArgb(128, 64, 0);
            BtnFiltrar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnFiltrar.ForeColor = Color.White;
            BtnFiltrar.Location = new Point(480, 150);
            BtnFiltrar.Margin = new Padding(2, 2, 2, 2);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(128, 33);
            BtnFiltrar.TabIndex = 4;
            BtnFiltrar.Text = "🔍 Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = false;
            BtnFiltrar.Click += BtnFiltrarFecha_Click;
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LUsuario.ForeColor = Color.SaddleBrown;
            LUsuario.Location = new Point(16, 71);
            LUsuario.Margin = new Padding(2, 0, 2, 0);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(59, 23);
            LUsuario.TabIndex = 4;
            LUsuario.Text = "Desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(248, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 5;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(16, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 6;
            label2.Text = "Vendedor/Gerente";
            // 
            // TxtBuscarVendedor
            // 
            TxtBuscarVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarVendedor.Font = new Font("Segoe UI", 10F);
            TxtBuscarVendedor.Location = new Point(16, 154);
            TxtBuscarVendedor.Margin = new Padding(2, 2, 2, 2);
            TxtBuscarVendedor.Name = "TxtBuscarVendedor";
            TxtBuscarVendedor.Size = new Size(289, 30);
            TxtBuscarVendedor.TabIndex = 6;
            // 
            // BtnBuscarVendedor
            // 
            BtnBuscarVendedor.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarVendedor.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscarVendedor.ForeColor = Color.White;
            BtnBuscarVendedor.Location = new Point(320, 150);
            BtnBuscarVendedor.Margin = new Padding(2, 2, 2, 2);
            BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            BtnBuscarVendedor.Size = new Size(144, 33);
            BtnBuscarVendedor.TabIndex = 7;
            BtnBuscarVendedor.Text = "👤 Buscar Vend.";
            BtnBuscarVendedor.UseVisualStyleBackColor = false;
            BtnBuscarVendedor.Click += BtnBuscarVendedor_Click;
            // 
            // BtnBucarCliente
            // 
            BtnBucarCliente.BackColor = Color.FromArgb(128, 64, 0);
            BtnBucarCliente.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBucarCliente.ForeColor = Color.White;
            BtnBucarCliente.Location = new Point(320, 204);
            BtnBucarCliente.Margin = new Padding(2, 2, 2, 2);
            BtnBucarCliente.Name = "BtnBucarCliente";
            BtnBucarCliente.Size = new Size(144, 33);
            BtnBucarCliente.TabIndex = 9;
            BtnBucarCliente.Text = "\U0001f9fe Buscar Cliente";
            BtnBucarCliente.UseVisualStyleBackColor = false;
            BtnBucarCliente.Click += BtnBuscarCliente_Click;
            // 
            // TxtBuscarCliente
            // 
            TxtBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarCliente.Font = new Font("Segoe UI", 10F);
            TxtBuscarCliente.Location = new Point(16, 208);
            TxtBuscarCliente.Margin = new Padding(2, 2, 2, 2);
            TxtBuscarCliente.Name = "TxtBuscarCliente";
            TxtBuscarCliente.Size = new Size(289, 30);
            TxtBuscarCliente.TabIndex = 8;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstadisticas.BackColor = Color.FromArgb(128, 64, 0);
            btnEstadisticas.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(440, 25);
            btnEstadisticas.Margin = new Padding(2, 2, 2, 2);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(168, 33);
            btnEstadisticas.TabIndex = 10;
            btnEstadisticas.Text = "📈 Ver Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // UCInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCInformes";
            Size = new Size(625, 500);
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
