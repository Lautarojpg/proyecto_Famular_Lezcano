using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class VentaDetalle
{
    public int IdDetalle { get; set; }

    public int Cantidad { get; set; }

    public int IdPelicula { get; set; }

    public int IdVenta { get; set; }

    public virtual Pelicula IdPeliculaNavigation { get; set; } = null!;

    public virtual VentaCabecera IdVentaNavigation { get; set; } = null!;
}
