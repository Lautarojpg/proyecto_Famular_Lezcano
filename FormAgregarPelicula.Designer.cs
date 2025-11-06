namespace proyecto_Famular_Lezcano
{
    partial class FormAgregarPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BGuardar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            TxtImagen = new TextBox();
            BtnImagen = new Button();
            label2 = new Label();
            CbCategoria = new ComboBox();
            TStock = new TextBox();
            LNombre = new Label();
            TNombre = new TextBox();
            TPrecio = new TextBox();
            LPrecio = new Label();
            TSinopsis = new TextBox();
            LStock = new Label();
            LSinopsis = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.FromArgb(128, 64, 0);
            BGuardar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.Bisque;
            BGuardar.Location = new Point(181, 417);
            BGuardar.Margin = new Padding(3, 4, 3, 4);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(118, 48);
            BGuardar.TabIndex = 17;
            BGuardar.Text = "Agregar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 64, 0);
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(158, 12);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 16;
            label1.Text = "Agregar Pelicula";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(TxtImagen);
            panel1.Controls.Add(BtnImagen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CbCategoria);
            panel1.Controls.Add(TStock);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TPrecio);
            panel1.Controls.Add(LPrecio);
            panel1.Controls.Add(TSinopsis);
            panel1.Controls.Add(LStock);
            panel1.Controls.Add(LSinopsis);
            panel1.Location = new Point(14, 55);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 355);
            panel1.TabIndex = 18;
            // 
            // TxtImagen
            // 
            TxtImagen.Location = new Point(144, 305);
            TxtImagen.Margin = new Padding(3, 4, 3, 4);
            TxtImagen.Name = "TxtImagen";
            TxtImagen.Size = new Size(285, 27);
            TxtImagen.TabIndex = 22;
            // 
            // BtnImagen
            // 
            BtnImagen.BackColor = Color.FromArgb(128, 64, 0);
            BtnImagen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnImagen.ForeColor = Color.Bisque;
            BtnImagen.Location = new Point(13, 295);
            BtnImagen.Margin = new Padding(3, 4, 3, 4);
            BtnImagen.Name = "BtnImagen";
            BtnImagen.Size = new Size(105, 43);
            BtnImagen.TabIndex = 21;
            BtnImagen.Text = "Imagen";
            BtnImagen.UseVisualStyleBackColor = false;
            BtnImagen.Click += BtnImagen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 252);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 20;
            label2.Text = "Categoria:";
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(144, 241);
            CbCategoria.Margin = new Padding(3, 4, 3, 4);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(138, 28);
            CbCategoria.TabIndex = 19;
            // 
            // TStock
            // 
            TStock.Location = new Point(144, 93);
            TStock.Margin = new Padding(3, 4, 3, 4);
            TStock.Name = "TStock";
            TStock.Size = new Size(140, 27);
            TStock.TabIndex = 10;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(13, 20);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(67, 20);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(144, 16);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(285, 27);
            TNombre.TabIndex = 0;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(144, 55);
            TPrecio.Margin = new Padding(3, 4, 3, 4);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(140, 27);
            TPrecio.TabIndex = 1;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(13, 65);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(53, 20);
            LPrecio.TabIndex = 5;
            LPrecio.Text = "Precio:";
            // 
            // TSinopsis
            // 
            TSinopsis.Location = new Point(144, 132);
            TSinopsis.Margin = new Padding(3, 4, 3, 4);
            TSinopsis.Multiline = true;
            TSinopsis.Name = "TSinopsis";
            TSinopsis.ScrollBars = ScrollBars.Both;
            TSinopsis.Size = new Size(285, 100);
            TSinopsis.TabIndex = 2;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(11, 104);
            LStock.Name = "LStock";
            LStock.Size = new Size(48, 20);
            LStock.TabIndex = 11;
            LStock.Text = "Stock:";
            // 
            // LSinopsis
            // 
            LSinopsis.AutoSize = true;
            LSinopsis.Location = new Point(11, 180);
            LSinopsis.Name = "LSinopsis";
            LSinopsis.Size = new Size(66, 20);
            LSinopsis.TabIndex = 6;
            LSinopsis.Text = "Sinopsis:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(464, 71);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormAgregarPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(737, 467);
            Controls.Add(pictureBox1);
            Controls.Add(BGuardar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAgregarPelicula";
            Text = "FormAgregarPelicula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Label label1;
        private Panel panel1;
        private TextBox TStock;
        private TextBox TEmail;
        private Label LNombre;
        private TextBox TNombre;
        private TextBox TPrecio;
        private Label LPrecio;
        private TextBox TSinopsis;
        private Label LStock;
        private Label LSinopsis;
        private Label label2;
        private ComboBox CbCategoria;
        private Label LEmail;
        private Button BtnImagen;
        private PictureBox pictureBox1;
        private TextBox TxtImagen;
    }
}