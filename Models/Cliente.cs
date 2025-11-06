using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string ApellidoCliente { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string ContrasenaCliente { get; set; } = null!;

    public virtual ICollection<VentaCabecera> VentaCabeceras { get; set; } = new List<VentaCabecera>();
}
