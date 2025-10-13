using proyecto_Famular_Lezcano.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarCliente : Form
    {
        private readonly ProyectoFamularLezcanoContext _context;
        private readonly bool _esEdicion;
        private readonly int _idCliente;

        public FormAgregarCliente()
        {
            InitializeComponent();
            _context = new ProyectoFamularLezcanoContext();
        }

        public FormAgregarCliente(Cliente cliente) : this()
        {
            _esEdicion = true;
            _idCliente = cliente.IdCliente;

            TNombre.Text = cliente.NombreCliente;
            TApellido.Text = cliente.ApellidoCliente;
            TEmail.Text = cliente.Email;
            TTelefono.Text = cliente.Telefono;
            TDireccion.Text = cliente.Direccion;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                if (_esEdicion)
                {
                    var cliente = _context.Clientes.FirstOrDefault(c => c.IdCliente == _idCliente);
                    if (cliente != null)
                    {
                        cliente.NombreCliente = TNombre.Text.Trim();
                        cliente.ApellidoCliente = TApellido.Text.Trim();
                        cliente.Email = TEmail.Text.Trim();
                        cliente.Telefono = TTelefono.Text.Trim();
                        cliente.Direccion = TDireccion.Text.Trim();

                        _context.SaveChanges();
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    var nuevo = new Cliente
                    {
                        NombreCliente = TNombre.Text.Trim(),
                        ApellidoCliente = TApellido.Text.Trim(),
                        Email = TEmail.Text.Trim(),
                        Telefono = TTelefono.Text.Trim(),
                        Direccion = TDireccion.Text.Trim()
                    };

                    _context.Clientes.Add(nuevo);
                    _context.SaveChanges();
                    MessageBox.Show("Cliente agregado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error",
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

            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(TEmail.Text) && !TEmail.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un email válido.");
                return false;
            }

            return true;
        }
    }
}
