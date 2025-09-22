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
            rbVendedor = new RadioButton();
            rbGerente = new RadioButton();
            rbAdministrador = new RadioButton();
            SuspendLayout();
            // 
            // TNombre
            // 
            TNombre.Location = new Point(161, 75);
            TNombre.Margin = new Padding(3, 4, 3, 4);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(285, 27);
            TNombre.TabIndex = 0;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(161, 129);
            TApellido.Margin = new Padding(3, 4, 3, 4);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(285, 27);
            TApellido.TabIndex = 1;
            // 
            // TNomUsuario
            // 
            TNomUsuario.Location = new Point(161, 224);
            TNomUsuario.Margin = new Padding(3, 4, 3, 4);
            TNomUsuario.Name = "TNomUsuario";
            TNomUsuario.Size = new Size(285, 27);
            TNomUsuario.TabIndex = 2;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(161, 273);
            TEmail.Margin = new Padding(3, 4, 3, 4);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(285, 27);
            TEmail.TabIndex = 3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(14, 79);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(67, 20);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(14, 133);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(66, 20);
            LApellido.TabIndex = 5;
            LApellido.Text = "Apellido";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(14, 231);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(142, 20);
            LNombreUsuario.TabIndex = 6;
            LNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(14, 277);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(49, 20);
            LEmail.TabIndex = 7;
            LEmail.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 24);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 8;
            label1.Text = "Agregar Vendedor";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(172, 389);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(86, 31);
            BAgregar.TabIndex = 9;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(14, 189);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(86, 20);
            LContraseña.TabIndex = 11;
            LContraseña.Text = "Contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(161, 179);
            TContraseña.Margin = new Padding(3, 4, 3, 4);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(285, 27);
            TContraseña.TabIndex = 10;
            // 
            // rbVendedor
            // 
            rbVendedor.AutoSize = true;
            rbVendedor.Location = new Point(14, 332);
            rbVendedor.Name = "rbVendedor";
            rbVendedor.Size = new Size(94, 24);
            rbVendedor.TabIndex = 12;
            rbVendedor.TabStop = true;
            rbVendedor.Text = "Vendedor";
            rbVendedor.UseVisualStyleBackColor = true;
            rbVendedor.CheckedChanged += rbVendedor_CheckedChanged;
            // 
            // rbGerente
            // 
            rbGerente.AutoSize = true;
            rbGerente.Location = new Point(172, 332);
            rbGerente.Name = "rbGerente";
            rbGerente.Size = new Size(82, 24);
            rbGerente.TabIndex = 13;
            rbGerente.TabStop = true;
            rbGerente.Text = "Gerente";
            rbGerente.UseVisualStyleBackColor = true;
            rbGerente.CheckedChanged += rbGerente_CheckedChanged;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.Location = new Point(322, 332);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(125, 24);
            rbAdministrador.TabIndex = 14;
            rbAdministrador.TabStop = true;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = true;
            rbAdministrador.CheckedChanged += rbAdministrador_CheckedChanged;
            // 
            // FormAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 433);
            Controls.Add(rbAdministrador);
            Controls.Add(rbGerente);
            Controls.Add(rbVendedor);
            Controls.Add(LContraseña);
            Controls.Add(TContraseña);
            Controls.Add(BAgregar);
            Controls.Add(label1);
            Controls.Add(LEmail);
            Controls.Add(LNombreUsuario);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(TEmail);
            Controls.Add(TNomUsuario);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAgregarUsuario";
            Text = "Agregar Vendedor";
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
        private RadioButton rbVendedor;
        private RadioButton rbGerente;
        private RadioButton rbAdministrador;
    }
}