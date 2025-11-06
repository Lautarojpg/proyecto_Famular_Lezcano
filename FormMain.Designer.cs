using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            PanelContent = new Panel();
            PanelMenu = new Panel();
            BtnBackUp = new Button();
            BtnSalir = new Button();
            BVendedores = new Button();
            BProductos = new Button();
            BInformes = new Button();
            BVentas = new Button();
            BClientes = new Button();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContent
            // 
            PanelContent.BackColor = Color.FromArgb(255, 224, 192);
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(200, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(1282, 753);
            PanelContent.TabIndex = 1;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(255, 192, 128);
            PanelMenu.Controls.Add(BtnBackUp);
            PanelMenu.Controls.Add(BVendedores);
            PanelMenu.Controls.Add(BProductos);
            PanelMenu.Controls.Add(BInformes);
            PanelMenu.Controls.Add(BVentas);
            PanelMenu.Controls.Add(BClientes);
            PanelMenu.Controls.Add(BtnSalir);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(200, 753);
            PanelMenu.TabIndex = 0;
            // 
            // BtnBackUp
            // 
            BtnBackUp.BackColor = Color.FromArgb(128, 64, 0);
            BtnBackUp.Dock = DockStyle.Top;
            BtnBackUp.FlatAppearance.BorderSize = 0;
            BtnBackUp.FlatStyle = FlatStyle.Flat;
            BtnBackUp.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBackUp.ForeColor = Color.White;
            BtnBackUp.Location = new Point(0, 450);
            BtnBackUp.Name = "BtnBackUp";
            BtnBackUp.Size = new Size(200, 90);
            BtnBackUp.TabIndex = 0;
            BtnBackUp.Text = "💾 BackUp";
            BtnBackUp.UseVisualStyleBackColor = false;
            BtnBackUp.Click += BtnBackUp_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.FromArgb(128, 64, 0);
            BtnSalir.Dock = DockStyle.Bottom;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnSalir.ForeColor = Color.White;
            BtnSalir.Location = new Point(0, 689);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(200, 64);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "❌ Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BVendedores
            // 
            BVendedores.BackColor = Color.FromArgb(128, 64, 0);
            BVendedores.Dock = DockStyle.Top;
            BVendedores.FlatAppearance.BorderSize = 0;
            BVendedores.FlatStyle = FlatStyle.Flat;
            BVendedores.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BVendedores.ForeColor = Color.White;
            BVendedores.Location = new Point(0, 360);
            BVendedores.Name = "BVendedores";
            BVendedores.Size = new Size(200, 90);
            BVendedores.TabIndex = 2;
            BVendedores.Text = "👤 Usuarios";
            BVendedores.UseVisualStyleBackColor = false;
            BVendedores.Click += BVendedores_Click;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.FromArgb(128, 64, 0);
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BProductos.ForeColor = Color.White;
            BProductos.Location = new Point(0, 270);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(200, 90);
            BProductos.TabIndex = 3;
            BProductos.Text = "🎞 Películas";
            BProductos.UseVisualStyleBackColor = false;
            BProductos.Click += BProductos_Click;
            // 
            // BInformes
            // 
            BInformes.BackColor = Color.FromArgb(128, 64, 0);
            BInformes.Dock = DockStyle.Top;
            BInformes.FlatAppearance.BorderSize = 0;
            BInformes.FlatStyle = FlatStyle.Flat;
            BInformes.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BInformes.ForeColor = Color.White;
            BInformes.Location = new Point(0, 180);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(200, 90);
            BInformes.TabIndex = 4;
            BInformes.Text = "📊 Informes";
            BInformes.UseVisualStyleBackColor = false;
            BInformes.Click += BInformes_Click;
            // 
            // BVentas
            // 
            BVentas.BackColor = Color.FromArgb(128, 64, 0);
            BVentas.Dock = DockStyle.Top;
            BVentas.FlatAppearance.BorderSize = 0;
            BVentas.FlatStyle = FlatStyle.Flat;
            BVentas.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BVentas.ForeColor = Color.White;
            BVentas.Location = new Point(0, 90);
            BVentas.Name = "BVentas";
            BVentas.Size = new Size(200, 90);
            BVentas.TabIndex = 5;
            BVentas.Text = "💵 Ventas";
            BVentas.UseVisualStyleBackColor = false;
            BVentas.Click += BVentas_Click;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.FromArgb(128, 64, 0);
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BClientes.ForeColor = Color.White;
            BClientes.Location = new Point(0, 0);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(200, 90);
            BClientes.TabIndex = 6;
            BClientes.Text = "👥 Clientes";
            BClientes.UseVisualStyleBackColor = false;
            BClientes.Click += BClientes_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1482, 753);
            Controls.Add(PanelContent);
            Controls.Add(PanelMenu);
            Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            MinimumSize = new Size(1500, 800);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🎥 Cine Vintage - Menú Principal";
            Load += FormMain_Load;
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel PanelContent;
        private Panel PanelMenu;
        private Button BInformes;
        private Button BVendedores;
        private Button BVentas;
        private Button BProductos;
        private Button BClientes;
        private Button BtnSalir;
        private Button BtnBackUp;
    }
}
