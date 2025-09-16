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
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Size = new Size(900, 600);
            // Panel Nueva Factura
            Panel pnlNuevaFactura = new Panel();
            pnlNuevaFactura.BackColor = Color.AntiqueWhite;
            pnlNuevaFactura.Size = new Size(400, 500);
            pnlNuevaFactura.Location = new Point(20, 40);
            pnlNuevaFactura.BorderStyle = BorderStyle.FixedSingle;
            Label lblTitulo1 = new Label();
            lblTitulo1.Text = "📄 Nueva Factura";
            lblTitulo1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.Maroon;
            lblTitulo1.AutoSize = true;
            lblTitulo1.Location = new Point(20, 20);
            // Combo Cliente
            ComboBox cbCliente = new ComboBox();
            cbCliente.Location = new Point(20, 70);
            cbCliente.Size = new Size(350, 30);
            cbCliente.Items.AddRange(new string[] { "María González", "Carlos Rodríguez", "Ana Martínez" });
            // Combo Película
            ComboBox cbPelicula = new ComboBox();
            cbPelicula.Location = new Point(20, 120);
            cbPelicula.Size = new Size(350, 30);
            cbPelicula.Items.AddRange(new string[] { "Casablanca (1942)", "El Padrino (1972)", "Vértigo (1958)" });
            // Cantidad
            NumericUpDown nudCantidad = new NumericUpDown();
            nudCantidad.Location = new Point(20, 170);
            nudCantidad.Size = new Size(100, 30);
            nudCantidad.Value = 1;
            // Labels Subtotal / IVA / Total
            Label lblSubtotal = new Label();
            lblSubtotal.Text = "Subtotal: $0.00";
            lblSubtotal.Location = new Point(20, 230);
            lblSubtotal.AutoSize = true;
            Label lblIVA = new Label();
            lblIVA.Text = "IVA (21%): $0.00";
            lblIVA.Location = new Point(20, 260);
            lblIVA.AutoSize = true;
            Label lblTotal = new Label();
            lblTotal.Text = "Total: $0.00";
            lblTotal.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotal.ForeColor = Color.Maroon;
            lblTotal.Location = new Point(20, 290);
            lblTotal.AutoSize = true;
            // Botón Generar Factura
            Button btnGenerar = new Button();
            btnGenerar.Text = "\U0001f9fe Generar Factura";
            btnGenerar.BackColor = Color.Maroon;
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Size = new Size(350, 40);
            btnGenerar.Location = new Point(20, 340);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            pnlNuevaFactura.Controls.Add(lblTitulo1);
            pnlNuevaFactura.Controls.Add(cbCliente);
            pnlNuevaFactura.Controls.Add(cbPelicula);
            pnlNuevaFactura.Controls.Add(nudCantidad);
            pnlNuevaFactura.Controls.Add(lblSubtotal);
            pnlNuevaFactura.Controls.Add(lblIVA);
            pnlNuevaFactura.Controls.Add(lblTotal);
            pnlNuevaFactura.Controls.Add(btnGenerar);
            // Panel Facturas Recientes
            Panel pnlFacturas = new Panel();
            pnlFacturas.BackColor = Color.AntiqueWhite;
            pnlFacturas.Size = new Size(400, 500);
            pnlFacturas.Location = new Point(450, 40);
            pnlFacturas.BorderStyle = BorderStyle.FixedSingle;
            Label lblTitulo2 = new Label();
            lblTitulo2.Text = "📑 Facturas Recientes";
            lblTitulo2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitulo2.ForeColor = Color.Maroon;
            lblTitulo2.AutoSize = true;
            lblTitulo2.Location = new Point(20, 20);
            // Ejemplo de Factura
            Label factura1 = new Label();
            factura1.Text = "Factura #001234 - María González - $24.19";
            factura1.Location = new Point(20, 70);
            factura1.AutoSize = true;
            Label factura2 = new Label();
            factura2.Text = "Factura #001233 - Carlos Rodríguez - $30.24";
            factura2.Location = new Point(20, 100);
            factura2.AutoSize = true;
            Label factura3 = new Label();
            factura3.Text = "Factura #001232 - Ana Martínez - $55.78";
            factura3.Location = new Point(20, 130);
            factura3.AutoSize = true;
            Button btnVerTodas = new Button();
            btnVerTodas.Text = "📂 Ver Todas las Facturas";
            btnVerTodas.BackColor = Color.Maroon;
            btnVerTodas.ForeColor = Color.White;
            btnVerTodas.Size = new Size(200, 40);
            btnVerTodas.Location = new Point(180, 440);
            btnVerTodas.FlatStyle = FlatStyle.Flat;
            pnlFacturas.Controls.Add(lblTitulo2);
            pnlFacturas.Controls.Add(factura1);
            pnlFacturas.Controls.Add(factura2);
            pnlFacturas.Controls.Add(factura3);
            pnlFacturas.Controls.Add(btnVerTodas);
            // Agregar a UserControl
            Controls.Add(pnlNuevaFactura);
            Controls.Add(pnlFacturas);
        }


        #endregion
    }
}