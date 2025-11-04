using proyecto_Famular_Lezcano.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace proyecto_Famular_Lezcano
{
    public partial class FormEstadisticas : Form
    {
        private ProyectoFamularLezcanoContext _context;

        public FormEstadisticas()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();

            // Configuración inicial
            DtpDesde.Value = DateTime.Today.AddMonths(-1);
            DtpHasta.Value = DateTime.Today;

            ConfigurarGraficos();
            CargarGraficos();
        }

        // -----------------------------------------------
        // CONFIGURAR GRÁFICOS
        // -----------------------------------------------
        private void ConfigurarGraficos()
        {
            // --- GRÁFICO DE TORTA (participación por película) ---
            ChartVentasTorta.Series.Clear();
            ChartVentasTorta.ChartAreas.Clear();
            ChartVentasTorta.ChartAreas.Add(new ChartArea("AreaTorta"));
            ChartVentasTorta.Titles.Clear();
            ChartVentasTorta.Titles.Add("Participación de Ventas por Película");

            var serieTorta = new Series("Películas")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0:#,0}"
            };
            ChartVentasTorta.Series.Add(serieTorta);

            // --- GRÁFICO DE BARRAS (ventas por vendedor) ---
            ChartVentasBarras.Series.Clear();
            ChartVentasBarras.ChartAreas.Clear();
            ChartVentasBarras.ChartAreas.Add(new ChartArea("AreaBarras"));
            ChartVentasBarras.Titles.Clear();
            ChartVentasBarras.Titles.Add("Ventas Totales por Vendedor");

            var serieBarras = new Series("Vendedores")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "{0:$#,0}"
            };
            ChartVentasBarras.Series.Add(serieBarras);

            // --- GRÁFICO DE PROYECCIÓN FUTURA (ventas mensuales + predicción) ---
            ChartProyeccionFutura.Series.Clear();
            ChartProyeccionFutura.ChartAreas.Clear();
            ChartProyeccionFutura.ChartAreas.Add(new ChartArea("AreaLinea"));
            ChartProyeccionFutura.Titles.Clear();
            ChartProyeccionFutura.Titles.Add("Proyección de Ventas Futuras");

            var serieLinea = new Series("Ventas")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                IsValueShownAsLabel = true,
                LabelFormat = "{0:$#,0}"
            };
            ChartProyeccionFutura.Series.Add(serieLinea);
        }

        // -----------------------------------------------
        // CARGAR DATOS EN LOS GRÁFICOS
        // -----------------------------------------------
        private void CargarGraficos()
        {
            DateTime desde = DtpDesde.Value.Date;
            DateTime hasta = DtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            // Películas más vendidas
            var ventasPorPelicula = _context.VentaDetalles
                .Where(v => v.IdVentaNavigation.FechaCompra >= desde && v.IdVentaNavigation.FechaCompra <= hasta)
                .GroupBy(v => v.IdPeliculaNavigation.NombrePelicula)
                .Select(g => new
                {
                    Pelicula = g.Key,
                    Cantidad = g.Sum(x => x.Cantidad)
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

            var serieTorta = ChartVentasTorta.Series["Películas"];
            serieTorta.Points.Clear();
            foreach (var item in ventasPorPelicula)
            {
                serieTorta.Points.AddXY(item.Pelicula, item.Cantidad);
            }

            // Ventas por vendedor
            var ventasPorVendedor = _context.VentaDetalles
                .Where(v => v.IdVentaNavigation.FechaCompra >= desde && v.IdVentaNavigation.FechaCompra <= hasta)
                .GroupBy(v => v.IdUsuarioNavigation.Nombre + " " + v.IdUsuarioNavigation.Apellido)
                .Select(g => new
                {
                    Vendedor = g.Key,
                    Total = g.Sum(x => x.Cantidad * x.IdPeliculaNavigation.Precio)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            var serieBarras = ChartVentasBarras.Series["Vendedores"];
            serieBarras.Points.Clear();
            foreach (var item in ventasPorVendedor)
            {
                serieBarras.Points.AddXY(item.Vendedor, item.Total);
            }

            // Ventas mensuales (para proyección)
            var ventasMensuales = _context.VentaCabeceras
                .Where(v => v.FechaCompra.HasValue)
                .AsEnumerable()
                .GroupBy(v => new { v.FechaCompra.Value.Year, v.FechaCompra.Value.Month })
                .Select(g => new
                {
                    Mes = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Total = g.Sum(x => x.TotalVenta)
                })
                .OrderBy(x => x.Mes)
                .ToList();


            var serieLinea = ChartProyeccionFutura.Series["Ventas"];
            serieLinea.Points.Clear();
            foreach (var item in ventasMensuales)
            {
                serieLinea.Points.AddXY(item.Mes.ToString("MMM yyyy"), item.Total);
            }

            // Estimación futura: predicción simple basada en promedio
            if (ventasMensuales.Count >= 2)
            {
                decimal? promedioIncremento = 0;
                for (int i = 1; i < ventasMensuales.Count; i++)
                {
                    var anterior = ventasMensuales[i - 1].Total;
                    var actual = ventasMensuales[i].Total;
                    promedioIncremento += (actual - anterior);
                }
                promedioIncremento /= (ventasMensuales.Count - 1);

                // Agregar estimación para los próximos 3 meses
                var ultimoMes = ventasMensuales.Last().Mes;
                var ultimoTotal = ventasMensuales.Last().Total;
                for (int i = 1; i <= 3; i++)
                {
                    var mesEstimado = ultimoMes.AddMonths(i);
                    ultimoTotal += promedioIncremento;
                    serieLinea.Points.AddXY($"{mesEstimado:MMM yyyy} (Est.)", ultimoTotal);
                }
            }
        }

        // -----------------------------------------------
        // EVENTOS
        // -----------------------------------------------
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarGraficos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
