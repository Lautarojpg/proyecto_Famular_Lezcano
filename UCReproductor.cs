using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using proyecto_Famular_Lezcano.Models;

namespace proyecto_Famular_Lezcano
{
    public partial class UCReproductor : UserControl
    {
        private readonly ProyectoFamularLezcanoContext _context;
        private WebView2 webView;

        public UCReproductor()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            InicializarWebView();
        }

        private async void InicializarWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(webView);
            await webView.EnsureCoreWebView2Async(null);
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código de visualización del ticket.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ticket = _context.Tickets.FirstOrDefault(t => t.CodVisualizacion == codigo);

                if (ticket == null)
                {
                    MessageBox.Show("No se encontró ningún ticket con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(ticket.Link))
                {
                    MessageBox.Show("Este ticket no tiene un enlace asociado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar el enlace del ticket directamente
                webView.Source = new Uri(ticket.Link);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar reproducir el video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
