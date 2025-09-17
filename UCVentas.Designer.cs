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
            lblTitulo1 = new Label();
            cbCliente = new ComboBox();
            cbPelicula = new ComboBox();
            nudCantidad = new NumericUpDown();
            lblSubtotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            btnGenerar = new Button();
            pnlFacturas = new Panel();
            lblTitulo2 = new Label();
            factura1 = new Label();
            factura2 = new Label();
            factura3 = new Label();
            btnVerTodas = new Button();
            pnlNuevaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            pnlFacturas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNuevaFactura
            // 
            pnlNuevaFactura.BackColor = Color.AntiqueWhite;
            pnlNuevaFactura.BorderStyle = BorderStyle.FixedSingle;
            pnlNuevaFactura.Controls.Add(lblTitulo1);
            pnlNuevaFactura.Controls.Add(cbCliente);
            pnlNuevaFactura.Controls.Add(cbPelicula);
            pnlNuevaFactura.Controls.Add(nudCantidad);
            pnlNuevaFactura.Controls.Add(lblSubtotal);
            pnlNuevaFactura.Controls.Add(lblIVA);
            pnlNuevaFactura.Controls.Add(lblTotal);
            pnlNuevaFactura.Controls.Add(btnGenerar);
            pnlNuevaFactura.Location = new Point(20, 40);
            pnlNuevaFactura.Name = "pnlNuevaFactura";
            pnlNuevaFactura.Size = new Size(388, 500);
            pnlNuevaFactura.TabIndex = 0;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.Maroon;
            lblTitulo1.Location = new Point(20, 20);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(182, 28);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "📄 Nueva Factura";
            // 
            // cbCliente
            // 
            cbCliente.Items.AddRange(new object[] { "María González", "Carlos Rodríguez", "Ana Martínez" });
            cbCliente.Location = new Point(20, 70);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(350, 28);
            cbCliente.TabIndex = 1;
            // 
            // cbPelicula
            // 
            cbPelicula.Items.AddRange(new object[] { "Casablanca (1942)", "El Padrino (1972)", "Vértigo (1958)" });
            cbPelicula.Location = new Point(20, 120);
            cbPelicula.Name = "cbPelicula";
            cbPelicula.Size = new Size(350, 28);
            cbPelicula.TabIndex = 2;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(20, 170);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 27);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 230);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(107, 20);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(20, 260);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(115, 20);
            lblIVA.TabIndex = 5;
            lblIVA.Text = "IVA (21%): $0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Maroon;
            lblTotal.Location = new Point(20, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.Maroon;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(20, 340);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(350, 40);
            btnGenerar.TabIndex = 7;
            btnGenerar.Text = "\U0001f9fe Generar Factura";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // pnlFacturas
            // 
            pnlFacturas.BackColor = Color.AntiqueWhite;
            pnlFacturas.BorderStyle = BorderStyle.FixedSingle;
            pnlFacturas.Controls.Add(lblTitulo2);
            pnlFacturas.Controls.Add(factura1);
            pnlFacturas.Controls.Add(factura2);
            pnlFacturas.Controls.Add(factura3);
            pnlFacturas.Controls.Add(btnVerTodas);
            pnlFacturas.Location = new Point(450, 40);
            pnlFacturas.Name = "pnlFacturas";
            pnlFacturas.Size = new Size(354, 500);
            pnlFacturas.TabIndex = 1;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo2.ForeColor = Color.Maroon;
            lblTitulo2.Location = new Point(20, 20);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(221, 28);
            lblTitulo2.TabIndex = 0;
            lblTitulo2.Text = "📑 Facturas Recientes";
            // 
            // factura1
            // 
            factura1.AutoSize = true;
            factura1.Location = new Point(20, 70);
            factura1.Name = "factura1";
            factura1.Size = new Size(291, 20);
            factura1.TabIndex = 1;
            factura1.Text = "Factura #001234 - María González - $24.19";
            // 
            // factura2
            // 
            factura2.AutoSize = true;
            factura2.Location = new Point(20, 100);
            factura2.Name = "factura2";
            factura2.Size = new Size(301, 20);
            factura2.TabIndex = 2;
            factura2.Text = "Factura #001233 - Carlos Rodríguez - $30.24";
            // 
            // factura3
            // 
            factura3.AutoSize = true;
            factura3.Location = new Point(20, 130);
            factura3.Name = "factura3";
            factura3.Size = new Size(276, 20);
            factura3.TabIndex = 3;
            factura3.Text = "Factura #001232 - Ana Martínez - $55.78";
            // 
            // btnVerTodas
            // 
            btnVerTodas.BackColor = Color.Maroon;
            btnVerTodas.FlatStyle = FlatStyle.Flat;
            btnVerTodas.ForeColor = Color.White;
            btnVerTodas.Location = new Point(151, 416);
            btnVerTodas.Name = "btnVerTodas";
            btnVerTodas.Size = new Size(200, 40);
            btnVerTodas.TabIndex = 4;
            btnVerTodas.Text = "📂 Ver Todas las Facturas";
            btnVerTodas.UseVisualStyleBackColor = false;
            // 
            // UCVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(pnlNuevaFactura);
            Controls.Add(pnlFacturas);
            Name = "UCVentas";
            Size = new Size(900, 600);
            pnlNuevaFactura.ResumeLayout(false);
            pnlNuevaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            pnlFacturas.ResumeLayout(false);
            pnlFacturas.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel pnlNuevaFactura;
        private Label lblTitulo1;
        private ComboBox cbCliente;
        private ComboBox cbPelicula;
        private NumericUpDown nudCantidad;
        private Label lblSubtotal;
        private Label lblIVA;
        private Label lblTotal;
        private Button btnGenerar;
        private Panel pnlFacturas;
        private Label lblTitulo2;
        private Label factura1;
        private Label factura2;
        private Label factura3;
        private Button btnVerTodas;
    }
}