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
            dgvPeliculas.RowTemplate.Height = 80; // Altura suficiente para miniaturas

            _context = new ProyectoFamularLezcanoContext();

            ConfigurarColumnas();
            CargarPeliculas();
        }

        private void ConfigurarColumnas()
        {
            dgvPeliculas.Columns.Clear();

            // Columna Imagen
            DataGridViewImageColumn colImagen = new DataGridViewImageColumn
            {
                HeaderText = "Imagen",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                DataPropertyName = "Miniatura"
            };
            dgvPeliculas.Columns.Add(colImagen);

            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "NombrePelicula" });
            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio" });
            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Stock" });
            dgvPeliculas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "NombreCategoria" });

            var btnModificar = new DataGridViewButtonColumn
            {
                HeaderText = "Acciones",
                Text = "Modificar",
                Name = "btnModificar",
                UseColumnTextForButtonValue = true
            };
            dgvPeliculas.Columns.Add(btnModificar);

            var btnEliminar = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "btnEliminar",
                UseColumnTextForButtonValue = true
            };
            dgvPeliculas.Columns.Add(btnEliminar);

            dgvPeliculas.CellClick += dgvPeliculas_CellClick;
        }

        private void CargarPeliculas()
        {
            var peliculas = _context.Peliculas
                .Include(p => p.IdCategoriaNavigation)
                .AsEnumerable() // pasamos a memoria para usar imágenes
                .Select(p => new
                {
                    p.IdPelicula,
                    p.NombrePelicula,
                    p.Precio,
                    p.Stock,
                    NombreCategoria = p.IdCategoriaNavigation?.Descripcion ?? "",
                    Miniatura = p.Imagen != null ? ByteArrayToImage(p.Imagen) : null
                })
                .ToList();

            dgvPeliculas.DataSource = peliculas;
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                return new Bitmap(img, new Size(80, 60)); // Miniatura
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarPelicula form = new FormAgregarPelicula())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    CargarPeliculas();
            }
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idPelicula = (int)dgvPeliculas.Rows[e.RowIndex].Cells["IdPelicula"].Value;
            var pelicula = _context.Peliculas
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefault(p => p.IdPelicula == idPelicula);

            if (pelicula == null) return;

            if (dgvPeliculas.Columns[e.ColumnIndex].Name == "btnModificar")
            {
                using (FormAgregarPelicula form = new FormAgregarPelicula(pelicula))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        CargarPeliculas();
                }
            }
            else if (dgvPeliculas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar esta película?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    _context.Peliculas.Remove(pelicula);
                    _context.SaveChanges();
                    CargarPeliculas();
                }
            }
        }

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
                    Miniatura = p.Imagen != null ? ByteArrayToImage(p.Imagen) : null
                })
                .ToList();

            dgvPeliculas.DataSource = resultados;
        }
    }
}
