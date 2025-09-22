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
            lblEmojiCine = new Label();
            lblInstrucciones = new Label();
            lblBienvenida = new Label();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            PanelMenu = new Panel();
            BVendedores = new Button();
            BProductos = new Button();
            BInformes = new Button();
            BVentas = new Button();
            BClientes = new Button();
            pictureBox4 = new PictureBox();
            PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PanelContent
            // 
            PanelContent.BackColor = Color.Bisque;
            PanelContent.Controls.Add(lblEmojiCine);
            PanelContent.Controls.Add(lblInstrucciones);
            PanelContent.Controls.Add(lblBienvenida);
            PanelContent.Location = new Point(231, 4);
            PanelContent.Margin = new Padding(3, 4, 3, 4);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(791, 663);
            PanelContent.TabIndex = 1;
            // 
            // lblEmojiCine
            // 
            lblEmojiCine.AutoSize = true;
            lblEmojiCine.Font = new Font("Segoe UI Emoji", 72F, FontStyle.Bold);
            lblEmojiCine.ForeColor = Color.Maroon;
            lblEmojiCine.Location = new Point(57, 387);
            lblEmojiCine.Name = "lblEmojiCine";
            lblEmojiCine.Size = new Size(230, 159);
            lblEmojiCine.TabIndex = 2;
            lblEmojiCine.Text = "🎥";
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.BackColor = Color.Maroon;
            lblInstrucciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstrucciones.ForeColor = Color.White;
            lblInstrucciones.Location = new Point(299, 221);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(471, 112);
            lblInstrucciones.TabIndex = 1;
            lblInstrucciones.Text = "👉 Usa los botones de la izquierda para navegar\n📌 También podés utilizar el buscador superior.\n\n🍿 ¡Que disfrutes la experiencia!";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Maroon;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.AliceBlue;
            lblBienvenida.Location = new Point(26, 65);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(744, 46);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "🎬 Bienvenido al Sistema de Cine Vintage 🎬";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(101, 51);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 51);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 51);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 51);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(255, 192, 128);
            PanelMenu.Controls.Add(BVendedores);
            PanelMenu.Controls.Add(BProductos);
            PanelMenu.Controls.Add(BInformes);
            PanelMenu.Controls.Add(BVentas);
            PanelMenu.Controls.Add(BClientes);
            PanelMenu.Controls.Add(pictureBox4);
            PanelMenu.Controls.Add(pictureBox3);
            PanelMenu.Controls.Add(pictureBox2);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(pictureBox5);
            PanelMenu.Location = new Point(0, 4);
            PanelMenu.Margin = new Padding(3, 4, 3, 4);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(224, 663);
            PanelMenu.TabIndex = 0;
            // 
            // BVendedores
            // 
            BVendedores.BackColor = Color.Maroon;
            BVendedores.FlatAppearance.BorderSize = 0;
            BVendedores.FlatStyle = FlatStyle.Flat;
            BVendedores.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BVendedores.ForeColor = Color.White;
            BVendedores.Location = new Point(21, 427);
            BVendedores.Name = "BVendedores";
            BVendedores.Size = new Size(130, 40);
            BVendedores.TabIndex = 1;
            BVendedores.Text = "\U0001f9d1‍ Usuarios";
            BVendedores.UseVisualStyleBackColor = false;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.Maroon;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BProductos.ForeColor = Color.White;
            BProductos.Location = new Point(21, 157);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(130, 40);
            BProductos.TabIndex = 3;
            BProductos.Text = "📦 Productos";
            BProductos.UseVisualStyleBackColor = false;
            // 
            // BInformes
            // 
            BInformes.BackColor = Color.Maroon;
            BInformes.FlatAppearance.BorderSize = 0;
            BInformes.FlatStyle = FlatStyle.Flat;
            BInformes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BInformes.ForeColor = Color.White;
            BInformes.Location = new Point(21, 580);
            BInformes.Name = "BInformes";
            BInformes.Size = new Size(130, 40);
            BInformes.TabIndex = 0;
            BInformes.Text = "📊 Informes";
            BInformes.UseVisualStyleBackColor = false;
            // 
            // BVentas
            // 
            BVentas.BackColor = Color.Maroon;
            BVentas.FlatAppearance.BorderSize = 0;
            BVentas.FlatStyle = FlatStyle.Flat;
            BVentas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BVentas.ForeColor = Color.White;
            BVentas.Location = new Point(21, 293);
            BVentas.Name = "BVentas";
            BVentas.Size = new Size(130, 40);
            BVentas.TabIndex = 2;
            BVentas.Text = "💵 Ventas";
            BVentas.UseVisualStyleBackColor = false;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.Maroon;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BClientes.ForeColor = Color.White;
            BClientes.Location = new Point(11, 35);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(130, 40);
            BClientes.TabIndex = 0;
            BClientes.Text = "👥 Clientes";
            BClientes.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 51);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1035, 683);
            Controls.Add(PanelContent);
            Controls.Add(PanelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "🎥 Cine Vintage - Menú";
            Load += FormMain_Load;
            PanelContent.ResumeLayout(false);
            PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelContent;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel PanelMenu;
        private PictureBox pictureBox4;
        private Button BInformes;
        private Button BVendedores;
        private Button BVentas;
        private Button BProductos;
        private Button BClientes;
        private Label lblBienvenida;
        private Label lblInstrucciones;
        private Label lblEmojiCine;
    }
}

