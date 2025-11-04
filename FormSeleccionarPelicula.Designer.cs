namespace proyecto_Famular_Lezcano
{
    partial class FormSeleccionarPelicula
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
            txtBuscar = new TextBox();
            dgvPeliculas = new DataGridView();
            btnBuscar = new Button();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(603, 23);
            txtBuscar.TabIndex = 0;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(12, 89);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(776, 349);
            dgvPeliculas.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(645, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(143, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Pelicula";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 9);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(86, 15);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar Pelicula";
            // 
            // FormSeleccionarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvPeliculas);
            Controls.Add(txtBuscar);
            Name = "FormSeleccionarPelicula";
            Text = "FormSeleccionarPelicula";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dgvPeliculas;
        private Button btnBuscar;
        private Label lblBuscar;
    }
}