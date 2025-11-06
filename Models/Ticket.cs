using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class Ticket
{
    public int IdTicket { get; set; }

    public string CodVisualizacion { get; set; } = null!;

    public string Link { get; set; } = null!;

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
