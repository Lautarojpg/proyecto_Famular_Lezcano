using AxWMPLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using proyecto_Famular_Lezcano.Models;

namespace proyecto_Famular_Lezcano
{
    public partial class UCReproductor : UserControl
    {
        private readonly ProyectoFamularLezcanoContext _context;

        public UCReproductor()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
        }

        private void UCReproductor_Load(object sender, EventArgs e)
        {
            InicializarReproductor();
        }

        private void InicializarReproductor()
        {
            try
            {
                // Configuración básica del reproductor
                axWindowsMediaPlayer1.uiMode = "full";
                axWindowsMediaPlayer1.settings.autoStart = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el reproductor: " + ex.Message);
            }
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

                // ✅ Reproducir el link del ticket
                axWindowsMediaPlayer1.URL = ticket.Link;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                MessageBox.Show("🎬 Reproduciendo: " + ticket.Link, "Reproductor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar reproducir el video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
