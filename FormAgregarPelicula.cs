using Microsoft.EntityFrameworkCore;
using proyecto_Famular_Lezcano.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarPelicula : Form
    {
        private readonly ProyectoFamularLezcanoContext _context;
        private readonly bool _esEdicion;
        private readonly int _idPelicula;

        public FormAgregarPelicula()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
            CargarCategorias();
        }

        public FormAgregarPelicula(Pelicula pelicula) : this()
        {
            _esEdicion = true;
            _idPelicula = pelicula.IdPelicula;

            TNombre.Text = pelicula.NombrePelicula;
            TPrecio.Text = pelicula.Precio.ToString();
            TStock.Text = pelicula.Stock.ToString();
            TSinopsis.Text = pelicula.Sinopsis;
            CbCategoria.SelectedValue = pelicula.IdCategoria;

            // Mostrar imagen si existe
            if (pelicula.Imagen != null)
            {
                using (var ms = new MemoryStream(pelicula.Imagen))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void CargarCategorias()
        {
            try
            {
                var categorias = _context.Categoria.ToList();

                if (categorias.Count == 0)
                {
                    MessageBox.Show("No hay categorías registradas. Agrega una antes de crear películas.",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CbCategoria.DataSource = categorias;
                CbCategoria.DisplayMember = "Descripcion";
                CbCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                decimal precio = decimal.Parse(TPrecio.Text);
                int stock = int.Parse(TStock.Text);
                int idCategoria = (int)CbCategoria.SelectedValue;

                byte[] imagenBytes = null;
                if (pictureBox1.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        // Redimensionar antes de guardar
                        Image imagenRedimensionada = RedimensionarImagen(pictureBox1.Image, 250, 200);
                        imagenRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagenBytes = ms.ToArray();
                    }
                }

                if (_esEdicion)
                {
                    var pelicula = _context.Peliculas.FirstOrDefault(p => p.IdPelicula == _idPelicula);
                    if (pelicula != null)
                    {
                        pelicula.NombrePelicula = TNombre.Text.Trim();
                        pelicula.Precio = precio;
                        pelicula.Stock = stock;
                        pelicula.Sinopsis = TSinopsis.Text.Trim();
                        pelicula.IdCategoria = idCategoria;
                        if (imagenBytes != null) pelicula.Imagen = imagenBytes;

                        _context.SaveChanges();
                        MessageBox.Show("Película actualizada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var nueva = new Pelicula
                    {
                        NombrePelicula = TNombre.Text.Trim(),
                        Precio = precio,
                        Stock = stock,
                        Sinopsis = TSinopsis.Text.Trim(),
                        IdCategoria = idCategoria,
                        Imagen = imagenBytes
                    };

                    _context.Peliculas.Add(nueva);
                    _context.SaveChanges();
                    MessageBox.Show("Película agregada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la película: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return false;
            }

            if (!decimal.TryParse(TPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return false;
            }

            if (!int.TryParse(TStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.");
                return false;
            }

            if (CbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return false;
            }

            return true;
        }

        private void BtnImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var original = Image.FromFile(openFileDialog.FileName);
                    var redimensionada = RedimensionarImagen(original, 250, 200);

                    pictureBox1.Image = redimensionada;
                    TxtImagen.Text = openFileDialog.FileName;
                }
            }
        }

        private Image RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            Bitmap nuevaImagen = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(nuevaImagen))
            {
                g.DrawImage(imagenOriginal, 0, 0, ancho, alto);
            }
            return nuevaImagen;
        }
    }
}
