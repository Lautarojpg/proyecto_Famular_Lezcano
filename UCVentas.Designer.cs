namespace proyecto_Famular_Lezcano
{
    partial class UCVentas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlNuevaFactura = new Panel();
            lblTitulo1 = new Label();
            label1 = new Label();
            txtBuscarCliente = new TextBox();
            BtnBuscarCliente = new Button();
            lblClienteSeleccionado = new Label();
            label2 = new Label();
            numCantidad = new NumericUpDown();
            BtnBuscarPelicula = new Button();
            lblPeliculaSeleccionada = new Label();
            BtnAgregar = new Button();
            dgvDetalle = new DataGridView();
            lblTotal = new Label();
            BtnEnviarCorreo = new Button();
            BtnGuardarFactura = new Button();
            BtnMisFacturas = new Button();
            pnlNuevaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // pnlNuevaFactura
            // 
            pnlNuevaFactura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNuevaFactura.BackColor = Color.FromArgb(255, 224, 192);
            pnlNuevaFactura.Controls.Add(lblTitulo1);
            pnlNuevaFactura.Controls.Add(label1);
            pnlNuevaFactura.Controls.Add(txtBuscarCliente);
            pnlNuevaFactura.Controls.Add(BtnBuscarCliente);
            pnlNuevaFactura.Controls.Add(lblClienteSeleccionado);
            pnlNuevaFactura.Controls.Add(label2);
            pnlNuevaFactura.Controls.Add(numCantidad);
            pnlNuevaFactura.Controls.Add(BtnBuscarPelicula);
            pnlNuevaFactura.Controls.Add(lblPeliculaSeleccionada);
            pnlNuevaFactura.Controls.Add(BtnAgregar);
            pnlNuevaFactura.Controls.Add(dgvDetalle);
            pnlNuevaFactura.Controls.Add(lblTotal);
            pnlNuevaFactura.Controls.Add(BtnEnviarCorreo);
            pnlNuevaFactura.Controls.Add(BtnGuardarFactura);
            pnlNuevaFactura.Controls.Add(BtnMisFacturas);
            pnlNuevaFactura.Location = new Point(2, 11);
            pnlNuevaFactura.Margin = new Padding(2);
            pnlNuevaFactura.Name = "pnlNuevaFactura";
            pnlNuevaFactura.Size = new Size(776, 578);
            pnlNuevaFactura.TabIndex = 0;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitulo1.Location = new Point(9, 10);
            lblTitulo1.Margin = new Padding(2, 0, 2, 0);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(239, 37);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "GESTIÓN VENTAS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(9, 63);
            label1.Name = "label1";
            label1.Size = new Size(323, 23);
            label1.TabIndex = 1;
            label1.Text = "Buscar cliente por email o por nombre:";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarCliente.Location = new Point(9, 91);
            txtBuscarCliente.Margin = new Padding(2);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(621, 27);
            txtBuscarCliente.TabIndex = 2;
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscarCliente.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarCliente.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnBuscarCliente.ForeColor = Color.White;
            BtnBuscarCliente.Location = new Point(642, 88);
            BtnBuscarCliente.Margin = new Padding(2);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Size = new Size(122, 33);
            BtnBuscarCliente.TabIndex = 3;
            BtnBuscarCliente.Text = "🔍 Cliente";
            BtnBuscarCliente.UseVisualStyleBackColor = false;
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.AutoSize = true;
            lblClienteSeleccionado.Font = new Font("Segoe UI", 10F);
            lblClienteSeleccionado.Location = new Point(9, 126);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(170, 23);
            lblClienteSeleccionado.TabIndex = 4;
            lblClienteSeleccionado.Text = "Cliente seleccionado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 163);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(90, 161);
            numCantidad.Margin = new Padding(2);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 27);
            numCantidad.TabIndex = 6;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnBuscarPelicula
            // 
            BtnBuscarPelicula.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscarPelicula.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnBuscarPelicula.ForeColor = Color.White;
            BtnBuscarPelicula.Location = new Point(230, 157);
            BtnBuscarPelicula.Margin = new Padding(2);
            BtnBuscarPelicula.Name = "BtnBuscarPelicula";
            BtnBuscarPelicula.Size = new Size(150, 33);
            BtnBuscarPelicula.TabIndex = 7;
            BtnBuscarPelicula.Text = "🎬 Buscar Película";
            BtnBuscarPelicula.UseVisualStyleBackColor = false;
            BtnBuscarPelicula.Click += BtnBuscarPelicula_Click;
            // 
            // lblPeliculaSeleccionada
            // 
            lblPeliculaSeleccionada.AutoSize = true;
            lblPeliculaSeleccionada.Font = new Font("Segoe UI", 10F);
            lblPeliculaSeleccionada.Location = new Point(9, 195);
            lblPeliculaSeleccionada.Name = "lblPeliculaSeleccionada";
            lblPeliculaSeleccionada.Size = new Size(173, 23);
            lblPeliculaSeleccionada.TabIndex = 8;
            lblPeliculaSeleccionada.Text = "Película seleccionada:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BtnAgregar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(642, 160);
            BtnAgregar.Margin = new Padding(2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(122, 33);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "\U0001f9fe Facturar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.ColumnHeadersHeight = 35;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.Location = new Point(9, 233);
            dgvDetalle.Margin = new Padding(2);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowTemplate.Height = 32;
            dgvDetalle.Size = new Size(755, 280);
            dgvDetalle.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(9, 518);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 28);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:";
            // 
            // BtnEnviarCorreo
            // 
            BtnEnviarCorreo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEnviarCorreo.BackColor = Color.FromArgb(128, 64, 0);
            BtnEnviarCorreo.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnEnviarCorreo.ForeColor = Color.White;
            BtnEnviarCorreo.Location = new Point(200, 512);
            BtnEnviarCorreo.Margin = new Padding(2);
            BtnEnviarCorreo.Name = "BtnEnviarCorreo";
            BtnEnviarCorreo.Size = new Size(150, 33);
            BtnEnviarCorreo.TabIndex = 12;
            BtnEnviarCorreo.Text = "📧 Mandar CSV";
            BtnEnviarCorreo.UseVisualStyleBackColor = false;
            BtnEnviarCorreo.Click += BtnEnviarCorreo_Click;
            // 
            // BtnGuardarFactura
            // 
            BtnGuardarFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGuardarFactura.BackColor = Color.FromArgb(128, 64, 0);
            BtnGuardarFactura.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnGuardarFactura.ForeColor = Color.White;
            BtnGuardarFactura.Location = new Point(642, 512);
            BtnGuardarFactura.Margin = new Padding(2);
            BtnGuardarFactura.Name = "BtnGuardarFactura";
            BtnGuardarFactura.Size = new Size(122, 33);
            BtnGuardarFactura.TabIndex = 13;
            BtnGuardarFactura.Text = "💾 Guardar";
            BtnGuardarFactura.UseVisualStyleBackColor = false;
            BtnGuardarFactura.Click += BtnGuardarFactura_Click;
            // 
            // BtnMisFacturas
            // 
            BtnMisFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMisFacturas.BackColor = Color.FromArgb(128, 64, 0);
            BtnMisFacturas.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            BtnMisFacturas.ForeColor = Color.White;
            BtnMisFacturas.Location = new Point(642, 10);
            BtnMisFacturas.Margin = new Padding(2);
            BtnMisFacturas.Name = "BtnMisFacturas";
            BtnMisFacturas.Size = new Size(122, 33);
            BtnMisFacturas.TabIndex = 14;
            BtnMisFacturas.Text = "📜 Facturas";
            BtnMisFacturas.UseVisualStyleBackColor = false;
            BtnMisFacturas.Click += BtnMisFacturas_Click;
            // 
            // UCVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(pnlNuevaFactura);
            Margin = new Padding(2);
            Name = "UCVentas";
            Size = new Size(781, 600);
            pnlNuevaFactura.ResumeLayout(false);
            pnlNuevaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNuevaFactura;
        private Label lblTitulo1;
        private Label label1;
        private TextBox txtBuscarCliente;
        private Button BtnBuscarCliente;
        private Label lblClienteSeleccionado;
        private Label label2;
        private NumericUpDown numCantidad;
        private Button BtnBuscarPelicula;
        private Label lblPeliculaSeleccionada;
        private Button BtnAgregar;
        private DataGridView dgvDetalle;
        private Label lblTotal;
        private Button BtnEnviarCorreo;
        private Button BtnGuardarFactura;
        private Button BtnMisFacturas;
    }
}
