namespace proyecto_Famular_Lezcano
{
    partial class FormMisFacturas
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
            dgvFacturas = new DataGridView();
            lblTitulo1 = new Label();
            dgvDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(14, 63);
            dgvFacturas.Margin = new Padding(3, 4, 3, 4);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.Size = new Size(887, 240);
            dgvFacturas.TabIndex = 0;
            dgvFacturas.CellContentClick += dgvFacturas_CellContentClick;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitulo1.Location = new Point(14, 12);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(164, 28);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "📄 Mis Facturas";
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(14, 327);
            dgvDetalles.Margin = new Padding(3, 4, 3, 4);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(887, 240);
            dgvDetalles.TabIndex = 2;
            // 
            // FormMisFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(914, 600);
            Controls.Add(dgvDetalles);
            Controls.Add(lblTitulo1);
            Controls.Add(dgvFacturas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMisFacturas";
            Text = "FormMisFacturas";
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFacturas;
        private Label lblTitulo1;
        private DataGridView dgvDetalles;
    }
}