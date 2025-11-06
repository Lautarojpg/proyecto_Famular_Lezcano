namespace proyecto_Famular_Lezcano
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            PanelContent = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            LUsuario = new Label();
            TUsuario = new TextBox();
            LPassword = new Label();
            TPassword = new TextBox();
            BLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();

            // 
            // PanelContent
            // 
            PanelContent.ColumnCount = 1;
            PanelContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelContent.RowCount = 6;
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PanelContent.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.BackColor = Color.Bisque;
            PanelContent.Controls.Add(pictureBox1, 0, 0);
            PanelContent.Controls.Add(LUsuario, 0, 1);
            PanelContent.Controls.Add(TUsuario, 0, 2);
            PanelContent.Controls.Add(LPassword, 0, 3);
            PanelContent.Controls.Add(TPassword, 0, 4);
            PanelContent.Controls.Add(BLogin, 0, 5);
            PanelContent.Location = new Point(0, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(800, 450);
            PanelContent.TabIndex = 0;

            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 120);
            pictureBox1.TabStop = false;

            // 
            // LUsuario
            // 
            LUsuario.Anchor = AnchorStyles.None;
            LUsuario.AutoSize = true;
            LUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LUsuario.ForeColor = Color.SaddleBrown;
            LUsuario.Text = "Usuario";
            LUsuario.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // TUsuario
            // 
            TUsuario.Anchor = AnchorStyles.None;
            TUsuario.BackColor = Color.Beige;
            TUsuario.BorderStyle = BorderStyle.FixedSingle;
            TUsuario.Size = new Size(250, 27);
            TUsuario.TabIndex = 2;

            // 
            // LPassword
            // 
            LPassword.Anchor = AnchorStyles.None;
            LPassword.AutoSize = true;
            LPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LPassword.ForeColor = Color.SaddleBrown;
            LPassword.Text = "Contraseña";
            LPassword.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // TPassword
            // 
            TPassword.Anchor = AnchorStyles.None;
            TPassword.BackColor = Color.Beige;
            TPassword.BorderStyle = BorderStyle.FixedSingle;
            TPassword.UseSystemPasswordChar = true;
            TPassword.Size = new Size(250, 27);
            TPassword.TabIndex = 3;

            // 
            // BLogin
            // 
            BLogin.Anchor = AnchorStyles.None;
            BLogin.BackColor = Color.Maroon;
            BLogin.FlatAppearance.BorderSize = 0;
            BLogin.FlatStyle = FlatStyle.Flat;
            BLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BLogin.ForeColor = Color.White;
            BLogin.Size = new Size(160, 40);
            BLogin.TabIndex = 4;
            BLogin.Text = "🔑 INGRESAR";
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;

            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelContent);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cine Vintage - Iniciar Sesión";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelContent;
        private PictureBox pictureBox1;
        private Label LUsuario;
        private TextBox TUsuario;
        private Label LPassword;
        private TextBox TPassword;
        private Button BLogin;
    }
}
