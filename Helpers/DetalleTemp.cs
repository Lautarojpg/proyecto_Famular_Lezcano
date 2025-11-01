using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_Famular_Lezcano.Helpers
{
    public class DetalleTemp
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
