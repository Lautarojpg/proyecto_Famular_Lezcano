namespace proyecto_Famular_Lezcano
{
    partial class UCVentas
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
            pnlNuevaFactura = new Panel();
            BtnMisFacturas = new Button();
            BtnEnviarCorreo = new Button();
            BtnExportarCSV = new Button();
            lblTotal = new Label();
            lblPeliculaSeleccionada = new Label();
            lblClienteSeleccionado = new Label();
            txtBuscarCliente = new TextBox();
            txtBuscarPelicula = new TextBox();
            BtnBuscarPelicula = new Button();
            BtnBuscarCliente = new Button();
            BtnGuardarFactura = new Button();
            dgvDetalle = new DataGridView();
            lblTitulo1 = new Label();
            numCantidad = new NumericUpDown();
            BtnAgregar = new Button();
            pnlNuevaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // pnlNuevaFactura
            // 
            pnlNuevaFactura.BackColor = Color.AntiqueWhite;
            pnlNuevaFactura.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevaFactura.Controls.Add(BtnMisFacturas);
            pnlNuevaFactura.Controls.Add(BtnEnviarCorreo);
            pnlNuevaFactura.Controls.Add(BtnExportarCSV);
            pnlNuevaFactura.Controls.Add(lblTotal);
            pnlNuevaFactura.Controls.Add(lblPeliculaSeleccionada);
            pnlNuevaFactura.Controls.Add(lblClienteSeleccionado);
            pnlNuevaFactura.Controls.Add(txtBuscarCliente);
            pnlNuevaFactura.Controls.Add(txtBuscarPelicula);
            pnlNuevaFactura.Controls.Add(BtnBuscarPelicula);
            pnlNuevaFactura.Controls.Add(BtnBuscarCliente);
            pnlNuevaFactura.Controls.Add(BtnGuardarFactura);
            pnlNuevaFactura.Controls.Add(dgvDetalle);
            pnlNuevaFactura.Controls.Add(lblTitulo1);
            pnlNuevaFactura.Controls.Add(numCantidad);
            pnlNuevaFactura.Controls.Add(BtnAgregar);
            pnlNuevaFactura.Location = new Point(3, 15);
            pnlNuevaFactura.Margin = new Padding(3, 2, 3, 2);
            pnlNuevaFactura.Name = "pnlNuevaFactura";
            pnlNuevaFactura.Size = new Size(685, 422);
            pnlNuevaFactura.TabIndex = 0;
            // 
            // BtnMisFacturas
            // 
            BtnMisFacturas.BackColor = Color.Maroon;
            BtnMisFacturas.FlatStyle = FlatStyle.Flat;
            BtnMisFacturas.ForeColor = Color.White;
            BtnMisFacturas.Location = new Point(546, 8);
            BtnMisFacturas.Margin = new Padding(3, 2, 3, 2);
            BtnMisFacturas.Name = "BtnMisFacturas";
            BtnMisFacturas.Size = new Size(119, 38);
            BtnMisFacturas.TabIndex = 19;
            BtnMisFacturas.Text = "Mis facturas";
            BtnMisFacturas.UseVisualStyleBackColor = false;
            BtnMisFacturas.Click += BtnMisFacturas_Click;
            // 
            // BtnEnviarCorreo
            // 
            BtnEnviarCorreo.BackColor = Color.Maroon;
            BtnEnviarCorreo.FlatStyle = FlatStyle.Flat;
            BtnEnviarCorreo.ForeColor = Color.White;
            BtnEnviarCorreo.Location = new Point(18, 355);
            BtnEnviarCorreo.Margin = new Padding(3, 2, 3, 2);
            BtnEnviarCorreo.Name = "BtnEnviarCorreo";
            BtnEnviarCorreo.Size = new Size(169, 30);
            BtnEnviarCorreo.TabIndex = 18;
            BtnEnviarCorreo.Text = "Mandar CSV";
            BtnEnviarCorreo.UseVisualStyleBackColor = false;
            BtnEnviarCorreo.Click += BtnEnviarCorreo_Click;
            // 
            // BtnExportarCSV
            // 
            BtnExportarCSV.BackColor = Color.Maroon;
            BtnExportarCSV.FlatStyle = FlatStyle.Flat;
            BtnExportarCSV.ForeColor = Color.White;
            BtnExportarCSV.Location = new Point(496, 355);
            BtnExportarCSV.Margin = new Padding(3, 2, 3, 2);
            BtnExportarCSV.Name = "BtnExportarCSV";
            BtnExportarCSV.Size = new Size(169, 30);
            BtnExportarCSV.TabIndex = 17;
            BtnExportarCSV.Text = "Generar CSV";
            BtnExportarCSV.UseVisualStyleBackColor = false;
            BtnExportarCSV.Click += BtnExportarCSV_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(18, 163);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 16;
            // 
            // lblPeliculaSeleccionada
            // 
            lblPeliculaSeleccionada.AutoSize = true;
            lblPeliculaSeleccionada.Location = new Point(496, 98);
            lblPeliculaSeleccionada.Name = "lblPeliculaSeleccionada";
            lblPeliculaSeleccionada.Size = new Size(0, 15);
            lblPeliculaSeleccionada.TabIndex = 15;
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.AutoSize = true;
            lblClienteSeleccionado.Location = new Point(496, 55);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(0, 15);
            lblClienteSeleccionado.TabIndex = 14;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(18, 52);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(338, 23);
            txtBuscarCliente.TabIndex = 13;
            // 
            // txtBuscarPelicula
            // 
            txtBuscarPelicula.Location = new Point(18, 90);
            txtBuscarPelicula.Name = "txtBuscarPelicula";
            txtBuscarPelicula.Size = new Size(338, 23);
            txtBuscarPelicula.TabIndex = 12;
            // 
            // BtnBuscarPelicula
            // 
            BtnBuscarPelicula.BackColor = Color.Maroon;
            BtnBuscarPelicula.FlatStyle = FlatStyle.Flat;
            BtnBuscarPelicula.ForeColor = Color.White;
            BtnBuscarPelicula.Location = new Point(373, 90);
            BtnBuscarPelicula.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarPelicula.Name = "BtnBuscarPelicula";
            BtnBuscarPelicula.Size = new Size(102, 23);
            BtnBuscarPelicula.TabIndex = 11;
            BtnBuscarPelicula.Text = "Buscar Pelicula";
            BtnBuscarPelicula.UseVisualStyleBackColor = false;
            BtnBuscarPelicula.Click += BtnBuscarPelicula_Click;
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.BackColor = Color.Maroon;
            BtnBuscarCliente.FlatStyle = FlatStyle.Flat;
            BtnBuscarCliente.ForeColor = Color.White;
            BtnBuscarCliente.Location = new Point(373, 52);
            BtnBuscarCliente.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Size = new Size(102, 23);
            BtnBuscarCliente.TabIndex = 10;
            BtnBuscarCliente.Text = "Buscar Cliente";
            BtnBuscarCliente.UseVisualStyleBackColor = false;
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // BtnGuardarFactura
            // 
            BtnGuardarFactura.BackColor = Color.Maroon;
            BtnGuardarFactura.FlatStyle = FlatStyle.Flat;
            BtnGuardarFactura.ForeColor = Color.White;
            BtnGuardarFactura.Location = new Point(581, 155);
            BtnGuardarFactura.Margin = new Padding(3, 2, 3, 2);
            BtnGuardarFactura.Name = "BtnGuardarFactura";
            BtnGuardarFactura.Size = new Size(84, 30);
            BtnGuardarFactura.TabIndex = 9;
            BtnGuardarFactura.Text = "Guardar";
            BtnGuardarFactura.UseVisualStyleBackColor = false;
            BtnGuardarFactura.Click += BtnGuardarFactura_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(18, 190);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(647, 134);
            dgvDetalle.TabIndex = 8;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.Maroon;
            lblTitulo1.Location = new Point(18, 15);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(144, 21);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "📄 Nueva Factura";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(18, 128);
            numCantidad.Margin = new Padding(3, 2, 3, 2);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(88, 23);
            numCantidad.TabIndex = 3;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Maroon;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(373, 155);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(119, 30);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "\U0001f9fe Facturar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // UCVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(pnlNuevaFactura);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCVentas";
            Size = new Size(691, 450);
            pnlNuevaFactura.ResumeLayout(false);
            pnlNuevaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel pnlNuevaFactura;
        private Label lblTitulo1;
        private NumericUpDown numCantidad;
        private Button BtnAgregar;
        private Button BtnGuardarFactura;
        private DataGridView dgvDetalle;
        private Button BtnBuscarPelicula;
        private Button BtnBuscarCliente;
        private TextBox txtBuscarCliente;
        private TextBox txtBuscarPelicula;
        private Label lblClienteSeleccionado;
        private Label lblPeliculaSeleccionada;
        private Label lblTotal;
        private Button BtnEnviarCorreo;
        private Button BtnExportarCSV;
        private Button BtnMisFacturas;
    }
}