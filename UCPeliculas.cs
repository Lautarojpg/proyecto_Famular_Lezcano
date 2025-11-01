using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class UCPeliculas : UserControl
    {
        private ProyectoFamularLezcanoContext _context;

        public UCPeliculas()
        {
            InitializeComponent();

            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.RowTemplate.Height = 80;

            _context = new ProyectoFamularLezcanoContext();

            ConfigurarColumnas();
            CargarPeliculas();
        }

        // ------------------------------------------------------------
        // CONFIGURACIÓN DE COLUMNAS
        // ------------------------------------------------------------
        private void ConfigurarColumnas()
        {
            dgvPeliculas.Columns.Clear();

            // 🔹 Columna oculta para el ID
            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "IdPelicula",
                Name = "IdPelicula",
                Visible = false
            });

            // 🔹 Imagen miniatura
            DataGridViewImageColumn colImagen = new DataGridViewImageColumn
            {
                HeaderText = "Imagen",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DataPropertyName = "Miniatura",
                Width = 100
            };
            dgvPeliculas.Columns.Add(colImagen);

            // 🔹 Demás columnas
            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NombrePelicula",
                Width = 180
            });

            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Width = 90
            });

            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Width = 70
            });

            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoría",
                DataPropertyName = "NombreCategoria",
                Width = 120
            });

            // 🔹 Botones de acción
            var btnModificar = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Modificar",
                Name = "btnModificar",
                UseColumnTextForButtonValue = true,
                Width = 90
            };
            dgvPeliculas.Columns.Add(btnModificar);

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "btnEliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dgvPeliculas.Columns.Add(btnEliminar);

            dgvPeliculas.CellClick += dgvPeliculas_CellClick;
        }

        // ------------------------------------------------------------
        // CARGAR PELÍCULAS
        // ------------------------------------------------------------
        private void CargarPeliculas()
        {
            var peliculas = _context.Peliculas
                .Include(p => p.IdCategoriaNavigation)
                .AsEnumerable()
                .Select(p => new
                {
                    p.IdPelicula,
                    p.NombrePelicula,
                    p.Precio,
                    p.Stock,
                    NombreCategoria = p.IdCategoriaNavigation?.Descripcion ?? "",
                    Miniatura = CargarMiniatura(p.Imagen)
                })
                .ToList();

            dgvPeliculas.DataSource = peliculas;
        }

        private Image CargarMiniatura(string rutaImagen)
        {
            if (string.IsNullOrWhiteSpace(rutaImagen) || !File.Exists(rutaImagen))
                return null;

            try
            {
                using (var original = Image.FromFile(rutaImagen))
                {
                    return new Bitmap(original, new Size(80, 60));
                }
            }
            catch
            {
                return null;
            }
        }

        // ------------------------------------------------------------
        // BOTÓN AGREGAR
        // ------------------------------------------------------------
        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarPelicula form = new FormAgregarPelicula())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    CargarPeliculas();
            }
        }

        // ------------------------------------------------------------
        // ACCIONES EN CELDAS
        // ------------------------------------------------------------
        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ✅ Obtenemos el ID oculto
            int idPelicula = Convert.ToInt32(dgvPeliculas.Rows[e.RowIndex].Cells["IdPelicula"].Value);
            var pelicula = _context.Peliculas
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefault(p => p.IdPelicula == idPelicula);

            if (pelicula == null) return;

            string columna = dgvPeliculas.Columns[e.ColumnIndex].Name;

            if (columna == "btnModificar")
            {
                using (FormAgregarPelicula form = new FormAgregarPelicula(pelicula))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        CargarPeliculas();
                }
            }
            else if (columna == "btnEliminar")
            {
                var confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar la película '{pelicula.NombrePelicula}'?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    _context.Peliculas.Remove(pelicula);
                    _context.SaveChanges();
                    MessageBox.Show("Película eliminada correctamente.");
                    CargarPeliculas();
                }
            }
        }

        // ------------------------------------------------------------
        // BOTÓN BUSCAR
        // ------------------------------------------------------------
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese un nombre de película para buscar.");
                return;
            }

            var resultados = _context.Peliculas
                .Include(p => p.IdCategoriaNavigation)
                .AsEnumerable()
                .Where(p => p.NombrePelicula.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .Select(p => new
                {
                    p.IdPelicula,
                    p.NombrePelicula,
                    p.Precio,
                    p.Stock,
                    NombreCategoria = p.IdCategoriaNavigation?.Descripcion ?? "",
                    Miniatura = CargarMiniatura(p.Imagen)
                })
                .ToList();

            dgvPeliculas.DataSource = resultados;
        }
    }
}
