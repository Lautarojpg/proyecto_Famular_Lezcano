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
            PeliculasPanel = new Panel();
            LPeliculas = new Label();
            ClientesPanel = new Panel();
            LClientes = new Label();
            VentasPanel = new Panel();
            LVentas = new Label();
            MasVendidasPanel = new Panel();
            LMasVendidas = new Label();
            ActividadPanel = new Panel();
            LActividad = new Label();
            LHeader = new Label();
            PeliculasPanel.SuspendLayout();
            ClientesPanel.SuspendLayout();
            VentasPanel.SuspendLayout();
            MasVendidasPanel.SuspendLayout();
            ActividadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PeliculasPanel
            // 
            PeliculasPanel.BackColor = Color.AntiqueWhite;
            PeliculasPanel.BorderStyle = BorderStyle.FixedSingle;
            PeliculasPanel.Controls.Add(LPeliculas);
            PeliculasPanel.Location = new Point(20, 80);
            PeliculasPanel.Name = "PeliculasPanel";
            PeliculasPanel.Size = new Size(250, 100);
            PeliculasPanel.TabIndex = 1;
            // 
            // LPeliculas
            // 
            LPeliculas.AutoSize = true;
            LPeliculas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LPeliculas.ForeColor = Color.Maroon;
            LPeliculas.Location = new Point(20, 30);
            LPeliculas.Name = "LPeliculas";
            LPeliculas.Size = new Size(185, 46);
            LPeliculas.TabIndex = 0;
            LPeliculas.Text = "🎬 Películas Cargadas\n247 (+12 este mes)";
            // 
            // ClientesPanel
            // 
            ClientesPanel.BackColor = Color.AntiqueWhite;
            ClientesPanel.BorderStyle = BorderStyle.FixedSingle;
            ClientesPanel.Controls.Add(LClientes);
            ClientesPanel.Location = new Point(320, 80);
            ClientesPanel.Name = "ClientesPanel";
            ClientesPanel.Size = new Size(250, 100);
            ClientesPanel.TabIndex = 2;
            // 
            // LClientes
            // 
            LClientes.AutoSize = true;
            LClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LClientes.ForeColor = Color.Maroon;
            LClientes.Location = new Point(20, 30);
            LClientes.Name = "LClientes";
            LClientes.Size = new Size(201, 46);
            LClientes.TabIndex = 0;
            LClientes.Text = "👥 Clientes Registrados\n1834 (+89 este mes)";
            // 
            // VentasPanel
            // 
            VentasPanel.BackColor = Color.AntiqueWhite;
            VentasPanel.BorderStyle = BorderStyle.FixedSingle;
            VentasPanel.Controls.Add(LVentas);
            VentasPanel.Location = new Point(620, 80);
            VentasPanel.Name = "VentasPanel";
            VentasPanel.Size = new Size(250, 100);
            VentasPanel.TabIndex = 3;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LVentas.ForeColor = Color.Maroon;
            LVentas.Location = new Point(20, 30);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(179, 46);
            LVentas.TabIndex = 0;
            LVentas.Text = "💵 Ventas Realizadas\n$45,672 (+15%)";
            // 
            // MasVendidasPanel
            // 
            MasVendidasPanel.BackColor = Color.AntiqueWhite;
            MasVendidasPanel.BorderStyle = BorderStyle.FixedSingle;
            MasVendidasPanel.Controls.Add(LMasVendidas);
            MasVendidasPanel.Location = new Point(20, 220);
            MasVendidasPanel.Name = "MasVendidasPanel";
            MasVendidasPanel.Size = new Size(400, 200);
            MasVendidasPanel.TabIndex = 4;
            // 
            // LMasVendidas
            // 
            LMasVendidas.AutoSize = true;
            LMasVendidas.Font = new Font("Segoe UI", 10F);
            LMasVendidas.ForeColor = Color.SaddleBrown;
            LMasVendidas.Location = new Point(34, 43);
            LMasVendidas.Name = "LMasVendidas";
            LMasVendidas.Size = new Size(296, 115);
            LMasVendidas.TabIndex = 0;
            LMasVendidas.Text = "🏆 Películas Más Vendidas\n\n- Casablanca (1942) → 156 ventas\n- El Padrino (1972) → 134 ventas\n- Ciudadano Kane (1941) → 98 ventas";
            // 
            // ActividadPanel
            // 
            ActividadPanel.BackColor = Color.AntiqueWhite;
            ActividadPanel.BorderStyle = BorderStyle.FixedSingle;
            ActividadPanel.Controls.Add(LActividad);
            ActividadPanel.Location = new Point(470, 220);
            ActividadPanel.Name = "ActividadPanel";
            ActividadPanel.Size = new Size(400, 200);
            ActividadPanel.TabIndex = 5;
            // 
            // LActividad
            // 
            LActividad.AutoSize = true;
            LActividad.Font = new Font("Segoe UI", 10F);
            LActividad.ForeColor = Color.SaddleBrown;
            LActividad.Location = new Point(20, 20);
            LActividad.Name = "LActividad";
            LActividad.Size = new Size(326, 138);
            LActividad.TabIndex = 0;
            LActividad.Text = "📌 Actividad Reciente\n\n- Nueva película agregada: Vértigo (1958)\n- Cliente registrado: María González\n- Venta realizada: $24.99\n- Usuario creado: operador_02";
            // 
            // LHeader
            // 
            LHeader.AutoSize = true;
            LHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LHeader.ForeColor = Color.SaddleBrown;
            LHeader.Location = new Point(20, 20);
            LHeader.Name = "LHeader";
            LHeader.Size = new Size(402, 37);
            LHeader.TabIndex = 0;
            LHeader.Text = "📊 Dashboard Administrativo";
            // 
            // UCInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(LHeader);
            Controls.Add(PeliculasPanel);
            Controls.Add(ClientesPanel);
            Controls.Add(VentasPanel);
            Controls.Add(MasVendidasPanel);
            Controls.Add(ActividadPanel);
            Name = "UCInformes";
            Size = new Size(900, 600);
            PeliculasPanel.ResumeLayout(false);
            PeliculasPanel.PerformLayout();
            ClientesPanel.ResumeLayout(false);
            ClientesPanel.PerformLayout();
            VentasPanel.ResumeLayout(false);
            VentasPanel.PerformLayout();
            MasVendidasPanel.ResumeLayout(false);
            MasVendidasPanel.PerformLayout();
            ActividadPanel.ResumeLayout(false);
            ActividadPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel PeliculasPanel;
        private Label LPeliculas;
        private Panel ClientesPanel;
        private Label LClientes;
        private Panel VentasPanel;
        private Label LVentas;
        private Panel MasVendidasPanel;
        private Label LMasVendidas;
        private Panel ActividadPanel;
        private Label LActividad;
        private Label LHeader;
    }
}
