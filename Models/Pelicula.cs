using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class Pelicula
{
    public int IdPelicula { get; set; }

    public string NombrePelicula { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public decimal Precio { get; set; }

    public string? Sinopsis { get; set; }

    public int Stock { get; set; }

    public int IdCategoria { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}
