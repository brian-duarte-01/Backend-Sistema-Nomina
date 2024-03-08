using System;
using System.Collections.Generic;

namespace Sistema_Nomina.Models;

public partial class Bono14
{
    public int IdBono14 { get; set; }

    public string? Empleado { get; set; }

    public decimal? Meses { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Salario { get; set; }

    public decimal? TotalBono14 { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
