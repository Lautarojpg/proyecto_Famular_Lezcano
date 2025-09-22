namespace proyecto_Famular_Lezcano
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelContent = new Panel();
            PanelMenu = new Panel();
            BVendedores = new Button();
            BProductos = new Button();
            BInformes = new Button();
            BVentas = new Button();
            BClientes = new Button();
            BtnSalir = new Button();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContent
            // 
            PanelContent.BackColor = Color.Bisque;
            PanelContent.Location = new Point(202, 3);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(692, 497);
            PanelContent.TabIndex = 1;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(255, 192, 128);
            PanelMenu.Controls.Add(BtnSalir);
            PanelMenu.Controls.Add(BVendedores);
            PanelMenu.Controls.Add(BProductos);
            PanelMenu.Controls.Add(BInformes);
            PanelMenu.Controls.Add(BVentas);
            PanelMenu.Controls.Add(BClientes);
            PanelMenu.Location = new Point(0, 3);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(196, 497);
            PanelMenu.TabIndex = 0;
            // 
            // BVendedores
            // 
            BVendedores.BackColor = Color.Maroon;
            BVendedores.FlatAppearance.BorderSize = 0;
            BVendedores.FlatStyle = FlatStyle.Flat;
            BVendedores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BVendedores.ForeColor = Color.White;
            BVendedores.Location = new Point(18, 260);
            BVendedores.Margin = new Padding(3, 2, 3, 2);
            BVendedores.Name = "BVendedores";
            BVendedores.Size = new Size(114, 30);
            BVendedores.TabIndex = 1;
            BVendedores.Text = "\U0001f9d1‍ Usuarios";
            BVendedores.UseVisualStyleBackColor = false;
            BVendedores.Click += BVendedores_Click;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Maroon;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BProductos.ForeColor = Color.White;
            BProductos.Location = new Point(18, 102);
            BProductos.Margin = new Padding(3, 2, 3, 2);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(114, 30);
            BProductos.TabIndex = 3;
            BProductos.Text = "📦 Productos";
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click;
            // 
            // BInformes
            // 
            BInformes.BackColor = Color.Maroon;
            BInformes.FlatAppearance.BorderSize = 0;
            BInformes.FlatStyle = FlatStyle.Flat;
            BInformes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BInformes.ForeColor = Color.White;
            BInformes.Location = new Point(18, 346);
            BInformes.Margin = new Padding(3, 2, 3, 2);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(114, 30);
            BInformes.TabIndex = 0;
            BInformes.Text = "📊 Informes";
            BInformes.UseVisualStyleBackColor = false;
            BInformes.Click += BInformes_Click;
            // 
            // BVentas
            // 
            BVentas.BackColor = Color.Maroon;
            BVentas.FlatAppearance.BorderSize = 0;
            BVentas.FlatStyle = FlatStyle.Flat;
            BVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BVentas.ForeColor = Color.White;
            BVentas.Location = new Point(18, 179);
            BVentas.Margin = new Padding(3, 2, 3, 2);
            BVentas.Name = "BVentas";
            BVentas.Size = new Size(114, 30);
            BVentas.TabIndex = 2;
            BVentas.Text = "💵 Ventas";
            BVentas.UseVisualStyleBackColor = false;
            BVentas.Click += BVentas_Click;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.Maroon;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BClientes.ForeColor = Color.White;
            BClientes.Location = new Point(18, 26);
            BClientes.Margin = new Padding(3, 2, 3, 2);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(114, 30);
            BClientes.TabIndex = 0;
            BClientes.Text = "👥 Clientes";
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.Maroon;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(18, 434);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(114, 30);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(906, 502);
            Controls.Add(PanelContent);
            Controls.Add(PanelMenu);
            Name = "FormMain";
            Text = "Cine Vintage - Menú";
            Load += FormMain_Load;
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion
        private Panel PanelContent;
        private Panel PanelMenu;
        private Button BInformes;
        private Button BVendedores;
        private Button BVentas;
        private Button BProductos;
        private Button BClientes;
        private Button BtnSalir;
    }
}

