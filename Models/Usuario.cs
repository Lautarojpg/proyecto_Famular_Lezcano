using System;
using System.Collections.Generic;

namespace proyecto_Famular_Lezcano.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int IdRol { get; set; }

    public bool? Estado { get; set; }

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
