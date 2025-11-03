namespace proyecto_Famular_Lezcano
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblHasta = new Label();
            lblDesde = new Label();
            DtpHasta = new DateTimePicker();
            DtpDesde = new DateTimePicker();
            BtnActualizar = new Button();
            BtnCerrar = new Button();
            ChartVentasTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartVentasBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ChartProyeccionFutura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ChartVentasTorta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartVentasBarras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartProyeccionFutura).BeginInit();
            SuspendLayout();
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.SaddleBrown;
            lblHasta.Location = new Point(364, 40);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 19);
            lblHasta.TabIndex = 12;
            lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.SaddleBrown;
            lblDesde.Location = new Point(84, 40);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(50, 19);
            lblDesde.TabIndex = 11;
            lblDesde.Text = "Desde";
            // 
            // DtpHasta
            // 
            DtpHasta.Location = new Point(289, 62);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(200, 23);
            DtpHasta.TabIndex = 10;
            // 
            // DtpDesde
            // 
            DtpDesde.Location = new Point(23, 62);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(200, 23);
            DtpDesde.TabIndex = 9;
            // 
            // BtnActualizar
            // 
            BtnActualizar.BackColor = Color.Maroon;
            BtnActualizar.FlatAppearance.BorderSize = 0;
            BtnActualizar.FlatStyle = FlatStyle.Flat;
            BtnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnActualizar.ForeColor = Color.White;
            BtnActualizar.Location = new Point(665, 62);
            BtnActualizar.Margin = new Padding(3, 2, 3, 2);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(114, 30);
            BtnActualizar.TabIndex = 14;
            BtnActualizar.Text = "Filtrar";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = Color.Maroon;
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCerrar.ForeColor = Color.White;
            BtnCerrar.Location = new Point(665, 111);
            BtnCerrar.Margin = new Padding(3, 2, 3, 2);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(114, 30);
            BtnCerrar.TabIndex = 13;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // ChartVentasTorta
            // 
            chartArea1.Name = "ChartArea1";
            ChartVentasTorta.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartVentasTorta.Legends.Add(legend1);
            ChartVentasTorta.Location = new Point(12, 161);
            ChartVentasTorta.Name = "ChartVentasTorta";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartVentasTorta.Series.Add(series1);
            ChartVentasTorta.Size = new Size(245, 244);
            ChartVentasTorta.TabIndex = 15;
            ChartVentasTorta.Text = "chart1";
            // 
            // ChartVentasBarras
            // 
            chartArea2.Name = "ChartArea1";
            ChartVentasBarras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            ChartVentasBarras.Legends.Add(legend2);
            ChartVentasBarras.Location = new Point(274, 161);
            ChartVentasBarras.Name = "ChartVentasBarras";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ChartVentasBarras.Series.Add(series2);
            ChartVentasBarras.Size = new Size(244, 244);
            ChartVentasBarras.TabIndex = 16;
            ChartVentasBarras.Text = "chart1";
            // 
            // ChartProyeccionFutura
            // 
            chartArea3.Name = "ChartArea1";
            ChartProyeccionFutura.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            ChartProyeccionFutura.Legends.Add(legend3);
            ChartProyeccionFutura.Location = new Point(535, 161);
            ChartProyeccionFutura.Name = "ChartProyeccionFutura";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            ChartProyeccionFutura.Series.Add(series3);
            ChartProyeccionFutura.Size = new Size(244, 244);
            ChartProyeccionFutura.TabIndex = 17;
            ChartProyeccionFutura.Text = "chart1";
            // 
            // FormEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChartProyeccionFutura);
            Controls.Add(ChartVentasBarras);
            Controls.Add(ChartVentasTorta);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnCerrar);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(DtpHasta);
            Controls.Add(DtpDesde);
            Name = "FormEstadisticas";
            Text = "FormEstadisticas";
            ((System.ComponentModel.ISupportInitialize)ChartVentasTorta).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartVentasBarras).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartProyeccionFutura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHasta;
        private Label lblDesde;
        private DateTimePicker DtpHasta;
        private DateTimePicker DtpDesde;
        private Button BtnActualizar;
        private Button BtnCerrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentasTorta;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVentasBarras;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartProyeccionFutura;
    }
}