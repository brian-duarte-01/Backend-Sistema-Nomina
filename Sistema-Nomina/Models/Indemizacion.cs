using System;
using System.Collections.Generic;

namespace Sistema_Nomina.Models;

public partial class Indemizacion
{
    public int IdIndemizacion { get; set; }

    public string? Empleado { get; set; }

    public decimal? Años { get; set; }

    public decimal? Meses { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Salario { get; set; }

    public decimal? TotalIndemizacion { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
