using System;
using System.Linq;
using System.Windows.Forms;
using proyecto_Famular_Lezcano.Models;

namespace proyecto_Famular_Lezcano
{
    public partial class FormSeleccionarPelicula : Form
    {
        private ProyectoFamularLezcanoContext _context;

        public Pelicula PeliculaSeleccionada { get; private set; }

        public FormSeleccionarPelicula()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            ConfigurarGrid();
            CargarPeliculas();
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdPelicula",              // 🔹 este es el cambio importante
                HeaderText = "ID",
                DataPropertyName = "IdPelicula",
                Width = 60
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Título",
                DataPropertyName = "NombrePelicula",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Género",
                DataPropertyName = "Genero",
                Width = 150
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio ($)",
                DataPropertyName = "PrecioVenta",
                Width = 100
            });

            // 🔘 Botón "Seleccionar"
            var btnSeleccionar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true,
                Width = 100
            };
            dataGridView1.Columns.Add(btnSeleccionar);

            dataGridView1.CellContentClick += DgvPeliculas_CellContentClick;
        }

        private void CargarPeliculas(string filtro = "")
        {
            var peliculas = _context.Peliculas
                .Where(p => string.IsNullOrEmpty(filtro) || p.NombrePelicula.Contains(filtro))
                .Select(p => new
                {
                    p.IdPelicula,
                    p.NombrePelicula,
                    Genero = p.IdCategoriaNavigation.Descripcion,
                    PrecioVenta = p.Precio

                })
                .ToList();

            dataGridView1.DataSource = peliculas;
        }

        private void BtnBuscarPelicula_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            CargarPeliculas(texto);
        }

        private void DgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                int idPelicula = (int)dataGridView1.Rows[e.RowIndex].Cells["IdPelicula"].Value;
                var pelicula = _context.Peliculas.FirstOrDefault(p => p.IdPelicula == idPelicula);
                if (pelicula is not null)
                {
                    PeliculaSeleccionada = pelicula;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la película seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
