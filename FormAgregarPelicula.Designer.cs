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
            BGuardar.BackColor = Color.Maroon;
            BGuardar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.Bisque;
            BGuardar.Location = new Point(158, 313);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(103, 36);
            BGuardar.TabIndex = 17;
            BGuardar.Text = "Agregar";
            BGuardar.UseVisualStyleBackColor = false;
            BGuardar.Click += BGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
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
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 266);
            panel1.TabIndex = 18;
            // 
            // TxtImagen
            // 
            TxtImagen.Location = new Point(126, 229);
            TxtImagen.Name = "TxtImagen";
            TxtImagen.Size = new Size(250, 23);
            TxtImagen.TabIndex = 22;
            // 
            // BtnImagen
            // 
            BtnImagen.BackColor = Color.Maroon;
            BtnImagen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnImagen.ForeColor = Color.Bisque;
            BtnImagen.Location = new Point(11, 221);
            BtnImagen.Name = "BtnImagen";
            BtnImagen.Size = new Size(92, 32);
            BtnImagen.TabIndex = 21;
            BtnImagen.Text = "Imagen";
            BtnImagen.UseVisualStyleBackColor = false;
            BtnImagen.Click += BtnImagen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 189);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 20;
            label2.Text = "Categoria:";
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(126, 181);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(121, 23);
            CbCategoria.TabIndex = 19;
            // 
            // TStock
            // 
            TStock.Location = new Point(126, 70);
            TStock.Name = "TStock";
            TStock.Size = new Size(123, 23);
            TStock.TabIndex = 10;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(11, 15);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(126, 12);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(250, 23);
            TNombre.TabIndex = 0;
            // 
            // TPrecio
            // 
            TPrecio.Location = new Point(126, 41);
            TPrecio.Name = "TPrecio";
            TPrecio.Size = new Size(123, 23);
            TPrecio.TabIndex = 1;
            // 
            // LPrecio
            // 
            LPrecio.AutoSize = true;
            LPrecio.Location = new Point(11, 49);
            LPrecio.Name = "LPrecio";
            LPrecio.Size = new Size(43, 15);
            LPrecio.TabIndex = 5;
            LPrecio.Text = "Precio:";
            // 
            // TSinopsis
            // 
            TSinopsis.Location = new Point(126, 99);
            TSinopsis.Multiline = true;
            TSinopsis.Name = "TSinopsis";
            TSinopsis.ScrollBars = ScrollBars.Both;
            TSinopsis.Size = new Size(250, 76);
            TSinopsis.TabIndex = 2;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Location = new Point(10, 78);
            LStock.Name = "LStock";
            LStock.Size = new Size(39, 15);
            LStock.TabIndex = 11;
            LStock.Text = "Stock:";
            // 
            // LSinopsis
            // 
            LSinopsis.AutoSize = true;
            LSinopsis.Location = new Point(10, 135);
            LSinopsis.Name = "LSinopsis";
            LSinopsis.Size = new Size(53, 15);
            LSinopsis.TabIndex = 6;
            LSinopsis.Text = "Sinopsis:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(406, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // FormAgregarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 350);
            Controls.Add(pictureBox1);
            Controls.Add(BGuardar);
            Controls.Add(label1);
            Controls.Add(panel1);
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