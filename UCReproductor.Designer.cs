namespace proyecto_Famular_Lezcano
{
    partial class UCReproductor
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReproductor));
            txtCodigo = new TextBox();
            LTitulo = new Label();
            panel1 = new Panel();
            btnReproducir = new Button();
            label1 = new Label();
            BtnBuscar = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(185, 53);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(330, 23);
            txtCodigo.TabIndex = 11;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LTitulo.ForeColor = Color.FromArgb(128, 64, 0);
            LTitulo.Location = new Point(2, 5);
            LTitulo.Margin = new Padding(2, 0, 2, 0);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(145, 30);
            LTitulo.TabIndex = 10;
            LTitulo.Text = "Mis Peliculas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnReproducir);
            panel1.Controls.Add(LTitulo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(BtnBuscar);
            panel1.Location = new Point(2, 13);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 96);
            panel1.TabIndex = 12;
            // 
            // btnReproducir
            // 
            btnReproducir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReproducir.BackColor = Color.FromArgb(128, 64, 0);
            btnReproducir.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            btnReproducir.ForeColor = Color.White;
            btnReproducir.Location = new Point(539, 46);
            btnReproducir.Margin = new Padding(2);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(126, 33);
            btnReproducir.TabIndex = 14;
            btnReproducir.Text = "Ver";
            btnReproducir.UseVisualStyleBackColor = false;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(2, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 18);
            label1.TabIndex = 13;
            label1.Text = "Codigo de visualizacion:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.FromArgb(128, 64, 0);
            BtnBuscar.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(1033, 32);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(107, 41);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "🔍 Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Bottom;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(3, 114);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(664, 315);
            axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // UCReproductor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(panel1);
            Name = "UCReproductor";
            Size = new Size(683, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCodigo;
        private Label LTitulo;
        private Panel panel1;
        private Button BtnBuscar;
        private Label label1;
        private Button btnReproducir;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
