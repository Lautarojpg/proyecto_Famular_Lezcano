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
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(126, 12);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(59, 20);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Location = new Point(113, 107);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(83, 20);
            LPassword.TabIndex = 1;
            LPassword.Text = "Contraseña";
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(96, 51);
            TUsuario.Margin = new Padding(3, 4, 3, 4);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(114, 27);
            TUsuario.TabIndex = 2;
            // 
            // TPassword
            // 
            TPassword.Location = new Point(96, 151);
            TPassword.Margin = new Padding(3, 4, 3, 4);
            TPassword.Name = "TPassword";
            TPassword.Size = new Size(114, 27);
            TPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            BLogin.Location = new Point(113, 201);
            BLogin.Margin = new Padding(3, 4, 3, 4);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(86, 31);
            BLogin.TabIndex = 4;
            BLogin.Text = "Ingresar";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(328, 260);
            Controls.Add(BLogin);
            Controls.Add(TPassword);
            Controls.Add(TUsuario);
            Controls.Add(LPassword);
            Controls.Add(LUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LUsuario;
        private Label LPassword;
        private TextBox TUsuario;
        private TextBox TPassword;
        private Button BLogin;
    }
}