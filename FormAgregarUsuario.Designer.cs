namespace proyecto_Famular_Lezcano
{
    partial class FormAgregarUsuario
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
            CbRol = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TNombre
            // 
            TNombre.Location = new Point(126, 20);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(250, 23);
            TNombre.TabIndex = 0;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(126, 56);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(250, 23);
            TApellido.TabIndex = 1;
            // 
            // TNomUsuario
            // 
            TNomUsuario.Location = new Point(126, 132);
            TNomUsuario.Name = "TNomUsuario";
            TNomUsuario.Size = new Size(250, 23);
            TNomUsuario.TabIndex = 2;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(126, 166);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(250, 23);
            TEmail.TabIndex = 3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(10, 23);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(10, 64);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 5;
            LApellido.Text = "Apellido";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(10, 135);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(113, 15);
            LNombreUsuario.TabIndex = 6;
            LNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(10, 169);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 7;
            LEmail.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 8;
            label1.Text = "Agregar Vendedor";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.Maroon;
            BAgregar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = Color.Bisque;
            BAgregar.Location = new Point(159, 290);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(103, 36);
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
            LContraseña.Size = new Size(70, 15);
            LContraseña.TabIndex = 11;
            LContraseña.Text = "Contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(126, 98);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(250, 23);
            TContraseña.TabIndex = 10;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 251);
            panel1.TabIndex = 15;
            // 
            // CbRol
            // 
            CbRol.FormattingEnabled = true;
            CbRol.Location = new Point(126, 209);
            CbRol.Name = "CbRol";
            CbRol.Size = new Size(121, 23);
            CbRol.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 212);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 15;
            label2.Text = "Rol:";
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(402, 325);
            Controls.Add(BAgregar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormAgregarUsuario";
            Text = "Agregar Vendedor";
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
        public Label label2;
    }
}