namespace proyecto_Famular_Lezcano
{
    partial class FormAgregarCliente
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
            TDireccion = new TextBox();
            label2 = new Label();
            TEmail = new TextBox();
            LNombre = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LApellido = new Label();
            TTelefono = new TextBox();
            LNombreUsuario = new Label();
            LEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.Maroon;
            BGuardar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.Bisque;
            BGuardar.Location = new Point(153, 253);
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
            label1.Location = new Point(138, 11);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 16;
            label1.Text = "Agregar Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(TDireccion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TEmail);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LNombreUsuario);
            panel1.Controls.Add(LEmail);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 212);
            panel1.TabIndex = 18;
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(126, 172);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(250, 23);
            TDireccion.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 175);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 15;
            label2.Text = "Direccion:";
            // 
            // TEmail
            // 
            TEmail.Location = new Point(126, 134);
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
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(10, 64);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 5;
            LApellido.Text = "Apellido";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(126, 94);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(250, 23);
            TTelefono.TabIndex = 2;
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(9, 102);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(55, 15);
            LNombreUsuario.TabIndex = 6;
            LNombreUsuario.Text = "Telefono:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(10, 142);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 7;
            LEmail.Text = "Email:";
            // 
            // FormAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(411, 296);
            Controls.Add(BGuardar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormAgregarCliente";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BGuardar;
        private Label label1;
        private Panel panel1;
        public Label label2;
        private TextBox TEmail;
        private Label LNombre;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LApellido;
        private TextBox TTelefono;
        private Label LNombreUsuario;
        private Label LEmail;
        private TextBox TDireccion;
    }
}