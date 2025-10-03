using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class VentaCabecera
{
    public int IdVenta { get; set; }

    public DateTime FechaCompra { get; set; }

    public decimal TotalVenta { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();
}
