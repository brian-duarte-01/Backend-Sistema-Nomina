using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Indemizacion
{
    public int IdIndemizacion { get; set; }

    public string? Empleado { get; set; }

    public int? Años { get; set; }

    public int? Meses { get; set; }

    public int? Dias { get; set; }

    public decimal? Salario { get; set; }

    public decimal? TotalIndemizacion { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
