namespace proyecto_Famular_Lezcano
{
    partial class FormLogin
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
            LUsuario = new Label();
            LPassword = new Label();
            TUsuario = new TextBox();
            TPassword = new TextBox();
            BLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LUsuario.ForeColor = Color.SaddleBrown;
            LUsuario.Location = new Point(106, 119);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(70, 23);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LPassword.ForeColor = Color.SaddleBrown;
            LPassword.Location = new Point(93, 187);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(99, 23);
            LPassword.TabIndex = 1;
            LPassword.Text = "Contraseña";
            // 
            // TUsuario
            // 
            TUsuario.BackColor = Color.Beige;
            TUsuario.BorderStyle = BorderStyle.FixedSingle;
            TUsuario.Location = new Point(39, 156);
            TUsuario.Margin = new Padding(3, 4, 3, 4);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(200, 27);
            TUsuario.TabIndex = 2;
            // 
            // TPassword
            // 
            TPassword.BackColor = Color.Beige;
            TPassword.BorderStyle = BorderStyle.FixedSingle;
            TPassword.Location = new Point(39, 224);
            TPassword.Margin = new Padding(3, 4, 3, 4);
            TPassword.Name = "TPassword";
            TPassword.Size = new Size(200, 27);
            TPassword.TabIndex = 3;
            TPassword.UseSystemPasswordChar = true;
            // 
            // BLogin
            // 
            BLogin.BackColor = Color.Maroon;
            BLogin.FlatAppearance.BorderSize = 0;
            BLogin.FlatStyle = FlatStyle.Flat;
            BLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BLogin.ForeColor = Color.White;
            BLogin.Location = new Point(66, 272);
            BLogin.Margin = new Padding(3, 4, 3, 4);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(150, 40);
            BLogin.TabIndex = 4;
            BLogin.Text = "🔑 INGRESAR";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(66, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(276, 325);
            Controls.Add(pictureBox1);
            Controls.Add(BLogin);
            Controls.Add(TPassword);
            Controls.Add(TUsuario);
            Controls.Add(LPassword);
            Controls.Add(LUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "Cine Vintage - Iniciar Sesión";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label LUsuario;
        private Label LPassword;
        private TextBox TUsuario;
        private TextBox TPassword;
        private Button BLogin;
        private PictureBox pictureBox1;
    }
}