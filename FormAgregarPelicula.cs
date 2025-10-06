using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarPelicula : Form
    {
        private ProyectoFamularLezcanoContext _context;
        private bool _esEdicion = false;
        private int _idPelicula = 0;

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
        }

        private void CargarCategorias()
        {
            CbCategoria.DataSource = _context.Categoria.ToList();
            CbCategoria.DisplayMember = "Descripcion";
            CbCategoria.ValueMember = "IdCategoria";
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TPrecio.Text) ||
                string.IsNullOrWhiteSpace(TStock.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!decimal.TryParse(TPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            if (!int.TryParse(TStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Stock inválido.");
                return;
            }

            if (_esEdicion)
            {
                var pelicula = _context.Peliculas.FirstOrDefault(p => p.IdPelicula == _idPelicula);
                if (pelicula != null)
                {
                    pelicula.NombrePelicula = TNombre.Text;
                    pelicula.Precio = precio;
                    pelicula.Stock = stock;
                    pelicula.Sinopsis = TSinopsis.Text;
                    pelicula.IdCategoria = (int)CbCategoria.SelectedValue;

                    _context.SaveChanges();
                }
            }
            else
            {
                var nueva = new Pelicula
                {
                    NombrePelicula = TNombre.Text,
                    Precio = precio,
                    Stock = stock,
                    Sinopsis = TSinopsis.Text,
                    IdCategoria = (int)CbCategoria.SelectedValue
                };

                _context.Peliculas.Add(nueva);
                _context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
