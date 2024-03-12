using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Nit { get; set; }

    public string? Calle { get; set; }

    public string? Avenida { get; set; }

    public string? Zona { get; set; }

    public decimal? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Empresa { get; set; }
}
