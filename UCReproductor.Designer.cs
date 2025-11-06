namespace proyecto_Famular_Lezcano
{
    partial class UCReproductor
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
            txtCodigo = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            btnReproducir = new Button();
            label1 = new Label();
            BtnBuscar = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Dock = DockStyle.Bottom;
            txtCodigo.Location = new Point(0, 101);
            txtCodigo.Margin = new Padding(2, 3, 2, 3);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(781, 27);
            txtCodigo.TabIndex = 11;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LTitulo.ForeColor = Color.FromArgb(128, 64, 0);
            LTitulo.Location = new Point(2, 7);
            LTitulo.Margin = new Padding(2, 0, 2, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(181, 37);
            LTitulo.TabIndex = 10;
            LTitulo.Text = "Mis Peliculas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnReproducir);
            panel1.Controls.Add(LTitulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(BtnBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 128);
            panel1.TabIndex = 12;
            // 
            // btnReproducir
            // 
            btnReproducir.BackColor = Color.FromArgb(128, 64, 0);
            btnReproducir.Dock = DockStyle.Right;
            btnReproducir.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            btnReproducir.ForeColor = Color.White;
            btnReproducir.Location = new Point(637, 0);
            btnReproducir.Margin = new Padding(2, 3, 2, 3);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(144, 78);
            btnReproducir.TabIndex = 14;
            btnReproducir.Text = "Ver";
            btnReproducir.UseVisualStyleBackColor = false;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Leelawadee", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(0, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 23);
            label1.TabIndex = 13;
            label1.Text = "Codigo de visualizacion:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(0, 0);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 15;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Bottom;
            webView21.Location = new Point(0, 137);
            webView21.Name = "webView21";
            webView21.Size = new Size(781, 463);
            webView21.TabIndex = 13;
            webView21.ZoomFactor = 1D;
            // 
            // UCReproductor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(webView21);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCReproductor";
            Size = new Size(781, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LTitulo;
        private Panel panel1;
        private Button BtnBuscar;
        private Label label1;
        private Button btnReproducir;
        public TextBox txtCodigo;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
