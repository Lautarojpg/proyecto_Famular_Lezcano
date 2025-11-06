namespace proyecto_Famular_Lezcano
{
    partial class FormAgregarUsuario
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
            TNombre = new TextBox();
            TApellido = new TextBox();
            TNomUsuario = new TextBox();
            TEmail = new TextBox();
            LNombre = new Label();
            LApellido = new Label();
            LNombreUsuario = new Label();
            LEmail = new Label();
            label1 = new Label();
            BAgregar = new Button();
            LContraseña = new Label();
            TContraseña = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            CbRol = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TNombre
            // 
            TNombre.Location = new Point(199, 16);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(250, 27);
            TNombre.TabIndex = 0;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(199, 52);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(250, 27);
            TApellido.TabIndex = 1;
            // 
            // TNomUsuario
            // 
            TNomUsuario.Location = new Point(199, 128);
            TNomUsuario.Name = "TNomUsuario";
            TNomUsuario.Size = new Size(250, 27);
            TNomUsuario.TabIndex = 2;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(199, 162);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(250, 27);
            TEmail.TabIndex = 3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(10, 23);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(67, 20);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(10, 64);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(69, 20);
            LApellido.TabIndex = 5;
            LApellido.Text = "Apellido:";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(10, 135);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(142, 20);
            LNombreUsuario.TabIndex = 6;
            LNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(10, 169);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(49, 20);
            LEmail.TabIndex = 7;
            LEmail.Text = "Email:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 64, 0);
            label1.Font = new Font("Yu Gothic UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(160, 20);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 8;
            label1.Text = "Agregar Vendedor";
            // 
            // BAgregar
            // 
            BAgregar.Anchor = AnchorStyles.Bottom;
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.Bisque;
            BAgregar.Location = new Point(190, 350);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(130, 40);
            BAgregar.TabIndex = 9;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(10, 106);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(86, 20);
            LContraseña.TabIndex = 11;
            LContraseña.Text = "Contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(199, 94);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(250, 27);
            TContraseña.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CbRol);
            panel1.Controls.Add(TContraseña);
            panel1.Controls.Add(TEmail);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TNomUsuario);
            panel1.Controls.Add(LContraseña);
            panel1.Controls.Add(LNombreUsuario);
            panel1.Controls.Add(LEmail);
            panel1.Location = new Point(7, 70);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 260);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 212);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 15;
            label2.Text = "Rol:";
            // 
            // CbRol
            // 
            CbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CbRol.FormattingEnabled = true;
            CbRol.Items.AddRange(new object[] { "Administrador", "Cliente", "Vendedor" });
            CbRol.Location = new Point(199, 205);
            CbRol.Name = "CbRol";
            CbRol.Size = new Size(150, 28);
            CbRol.TabIndex = 14;
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(500, 420);
            Controls.Add(BAgregar);
            Controls.Add(label1);
            Controls.Add(panel1);
            MinimumSize = new Size(450, 400);
            Name = "FormAgregarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TNomUsuario;
        private TextBox TEmail;
        private Label LNombre;
        private Label LApellido;
        private Label LNombreUsuario;
        private Label LEmail;
        private Label label1;
        private Button BAgregar;
        private Label LContraseña;
        private TextBox TContraseña;
        private Panel panel1;
        private ComboBox CbRol;
        private Label label2;
    }
}
