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
            BtnGuardarFactura = new Button();
            dgvDetalle = new DataGridView();
            lblTitulo1 = new Label();
            CbCliente = new ComboBox();
            CbPeliculas = new ComboBox();
            numCantidad = new NumericUpDown();
            lblSubtotal = new Label();
            lblTotal = new Label();
            BtnAgregar = new Button();
            lblIVA = new Label();
            pnlNuevaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // pnlNuevaFactura
            // 
            pnlNuevaFactura.BackColor = Color.AntiqueWhite;
            pnlNuevaFactura.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevaFactura.Controls.Add(BtnGuardarFactura);
            pnlNuevaFactura.Controls.Add(dgvDetalle);
            pnlNuevaFactura.Controls.Add(lblTitulo1);
            pnlNuevaFactura.Controls.Add(CbCliente);
            pnlNuevaFactura.Controls.Add(CbPeliculas);
            pnlNuevaFactura.Controls.Add(numCantidad);
            pnlNuevaFactura.Controls.Add(lblSubtotal);
            pnlNuevaFactura.Controls.Add(lblIVA);
            pnlNuevaFactura.Controls.Add(lblTotal);
            pnlNuevaFactura.Controls.Add(BtnAgregar);
            pnlNuevaFactura.Location = new Point(3, 30);
            pnlNuevaFactura.Margin = new Padding(3, 2, 3, 2);
            pnlNuevaFactura.Name = "pnlNuevaFactura";
            pnlNuevaFactura.Size = new Size(685, 376);
            pnlNuevaFactura.TabIndex = 0;
            // 
            // BtnGuardarFactura
            // 
            BtnGuardarFactura.BackColor = Color.Maroon;
            BtnGuardarFactura.FlatStyle = FlatStyle.Flat;
            BtnGuardarFactura.ForeColor = Color.White;
            BtnGuardarFactura.Location = new Point(581, 190);
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
            dgvDetalle.Location = new Point(18, 225);
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
            // CbCliente
            // 
            CbCliente.Items.AddRange(new object[] { "María González", "Carlos Rodríguez", "Ana Martínez" });
            CbCliente.Location = new Point(18, 52);
            CbCliente.Margin = new Padding(3, 2, 3, 2);
            CbCliente.Name = "CbCliente";
            CbCliente.Size = new Size(307, 23);
            CbCliente.TabIndex = 1;
            // 
            // CbPeliculas
            // 
            CbPeliculas.Items.AddRange(new object[] { "Casablanca (1942)", "El Padrino (1972)", "Vértigo (1958)" });
            CbPeliculas.Location = new Point(18, 90);
            CbPeliculas.Margin = new Padding(3, 2, 3, 2);
            CbPeliculas.Name = "CbPeliculas";
            CbPeliculas.Size = new Size(307, 23);
            CbPeliculas.TabIndex = 2;
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
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(18, 163);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(84, 15);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Maroon;
            lblTotal.Location = new Point(20, 196);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(86, 19);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: $0.00";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Maroon;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(409, 190);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(119, 30);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "\U0001f9fe Facturar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(135, 163);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(90, 15);
            lblIVA.TabIndex = 5;
            lblIVA.Text = "IVA (21%): $0.00";
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
        private ComboBox CbCliente;
        private ComboBox CbPeliculas;
        private NumericUpDown numCantidad;
        private Label lblSubtotal;
        private Label lblTotal;
        private Button BtnAgregar;
        private Button BtnGuardarFactura;
        private DataGridView dgvDetalle;
        private Label lblIVA;
    }
}