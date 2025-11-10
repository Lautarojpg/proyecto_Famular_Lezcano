namespace proyecto_Famular_Lezcano
{
    partial class FormEstadisticas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblTitulo = new Label();
            lblHasta = new Label();
            lblDesde = new Label();
            DtpHasta = new DateTimePicker();
            DtpDesde = new DateTimePicker();
            BtnActualizar = new Button();
            BtnCerrar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ChartVentasTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartVentasBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartProyeccionFutura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(ChartVentasTorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ChartVentasBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ChartProyeccionFutura)).BeginInit();
            SuspendLayout();

            // Form
            BackColor = Color.FromArgb(255, 224, 192);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Text = "Estadísticas de Ventas";
            StartPosition = FormStartPosition.CenterScreen;

            // lblTitulo
            lblTitulo.Text = "📊 ESTADÍSTICAS DE VENTAS";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitulo.AutoSize = false;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;

            // lblDesde
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.SaddleBrown;
            lblDesde.Location = new Point(60, 80);
            lblDesde.Text = "Desde:";

            // DtpDesde
            DtpDesde.Location = new Point(120, 80);
            DtpDesde.Size = new Size(200, 23);

            // lblHasta
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.SaddleBrown;
            lblHasta.Location = new Point(350, 80);
            lblHasta.Text = "Hasta:";

            // DtpHasta
            DtpHasta.Location = new Point(410, 80);
            DtpHasta.Size = new Size(200, 23);

            // BtnActualizar
            BtnActualizar.BackColor = Color.Maroon;
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Size = new Size(110, 35);
            BtnActualizar.Text = "Filtrar";
            BtnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnActualizar.Location = new Point(ClientSize.Width - 260, 75);
            BtnActualizar.Click += BtnActualizar_Click;

            // BtnCerrar
            BtnCerrar.BackColor = Color.Maroon;
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCerrar.ForeColor = Color.White;
            BtnCerrar.Size = new Size(110, 35);
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCerrar.Location = new Point(ClientSize.Width - 130, 75);
            BtnCerrar.Click += BtnCerrar_Click;

            // tableLayoutPanel1
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Padding = new Padding(20, 130, 20, 20);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // ChartVentasTorta
            chartArea1.Name = "ChartArea1";
            ChartVentasTorta.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartVentasTorta.Legends.Add(legend1);
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartVentasTorta.Series.Add(series1);
            ChartVentasTorta.Dock = DockStyle.Fill;

            // ChartVentasBarras
            chartArea2.Name = "ChartArea1";
            ChartVentasBarras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartVentasBarras.Legends.Add(legend2);
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartVentasBarras.Series.Add(series2);
            ChartVentasBarras.Dock = DockStyle.Fill;

            // ChartProyeccionFutura
            chartArea3.Name = "ChartArea1";
            ChartProyeccionFutura.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ChartProyeccionFutura.Legends.Add(legend3);
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            ChartProyeccionFutura.Series.Add(series3);
            ChartProyeccionFutura.Dock = DockStyle.Fill;

            // Añadir gráficos
            tableLayoutPanel1.Controls.Add(ChartVentasTorta, 0, 0);
            tableLayoutPanel1.Controls.Add(ChartVentasBarras, 1, 0);
            tableLayoutPanel1.Controls.Add(ChartProyeccionFutura, 2, 0);

            // Controles al formulario
            Controls.Add(lblTitulo);
            Controls.Add(lblDesde);
            Controls.Add(DtpDesde);
            Controls.Add(lblHasta);
            Controls.Add(DtpHasta);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnCerrar);
            Controls.Add(tableLayoutPanel1);

            ((System.ComponentModel.ISupportInitialize)(ChartVentasTorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ChartVentasBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ChartProyeccionFutura)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblHasta;
        private Label lblDesde;
        private DateTimePicker DtpHasta;
        private DateTimePicker DtpDesde;
        private Button BtnActualizar;
        private Button BtnCerrar;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentasTorta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentasBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProyeccionFutura;
    }
}
