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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label3 = new Label();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFacturas.Location = new Point(16, 292);
            dgvFacturas.Margin = new Padding(2, 3, 2, 3);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.RowTemplate.Height = 30;
            dgvFacturas.Size = new Size(904, 192);
            dgvFacturas.TabIndex = 1;
            // 
            // DtpDesde
            // 
            DtpDesde.Font = new Font("Segoe UI", 10F);
            DtpDesde.Location = new Point(16, 92);
            DtpDesde.Margin = new Padding(2, 3, 2, 3);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(201, 30);
            DtpDesde.TabIndex = 2;
            // 
            // DtpHasta
            // 
            DtpHasta.Font = new Font("Segoe UI", 10F);
            DtpHasta.Location = new Point(248, 92);
            DtpHasta.Margin = new Padding(2, 3, 2, 3);
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
            BtnLimpiar.Location = new Point(784, 245);
            BtnLimpiar.Margin = new Padding(2, 3, 2, 3);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(128, 41);
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
            BtnFiltrar.Location = new Point(506, 87);
            BtnFiltrar.Margin = new Padding(2, 3, 2, 3);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(128, 45);
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
            label2.Location = new Point(16, 129);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 23);
            label2.TabIndex = 6;
            label2.Text = "Vendedor/Gerente    (id)";
            // 
            // TxtBuscarVendedor
            // 
            TxtBuscarVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBuscarVendedor.Font = new Font("Segoe UI", 10F);
            TxtBuscarVendedor.Location = new Point(16, 155);
            TxtBuscarVendedor.Margin = new Padding(2, 3, 2, 3);
            TxtBuscarVendedor.Name = "TxtBuscarVendedor";
            TxtBuscarVendedor.Size = new Size(601, 30);
            TxtBuscarVendedor.TabIndex = 6;
            // 
            // BtnBuscarVendedor
            // 
            BtnBuscarVendedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscarVendedor.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarVendedor.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscarVendedor.ForeColor = Color.White;
            BtnBuscarVendedor.Location = new Point(632, 148);
            BtnBuscarVendedor.Margin = new Padding(2, 3, 2, 3);
            BtnBuscarVendedor.Name = "BtnBuscarVendedor";
            BtnBuscarVendedor.Size = new Size(144, 43);
            BtnBuscarVendedor.TabIndex = 7;
            BtnBuscarVendedor.Text = "👤 Buscar Vend.";
            BtnBuscarVendedor.UseVisualStyleBackColor = false;
            BtnBuscarVendedor.Click += BtnBuscarVendedor_Click;
            // 
            // BtnBucarCliente
            // 
            BtnBucarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBucarCliente.BackColor = Color.FromArgb(128, 64, 0);
            BtnBucarCliente.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBucarCliente.ForeColor = Color.White;
            BtnBucarCliente.Location = new Point(632, 200);
            BtnBucarCliente.Margin = new Padding(2, 3, 2, 3);
            BtnBucarCliente.Name = "BtnBucarCliente";
            BtnBucarCliente.Size = new Size(144, 41);
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
            TxtBuscarCliente.Margin = new Padding(2, 3, 2, 3);
            TxtBuscarCliente.Name = "TxtBuscarCliente";
            TxtBuscarCliente.Size = new Size(601, 30);
            TxtBuscarCliente.TabIndex = 8;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEstadisticas.BackColor = Color.FromArgb(128, 64, 0);
            btnEstadisticas.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(784, 7);
            btnEstadisticas.Margin = new Padding(2, 3, 2, 3);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(151, 71);
            btnEstadisticas.TabIndex = 10;
            btnEstadisticas.Text = "📈 Ver Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = false;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(16, 182);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 23);
            label3.TabIndex = 11;
            label3.Text = "Cliente (nombre, email)";
            // 
            // UCInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(label3);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "UCInformes";
            Size = new Size(937, 500);
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
        public TextBox TxtBuscarCliente;
        private Button btnEstadisticas;
        private Button BtnBucarCliente;
        private Label label3;
    }
}
