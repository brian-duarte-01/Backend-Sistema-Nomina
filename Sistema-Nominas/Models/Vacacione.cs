using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Vacacione
{
    public int IdVacaciones { get; set; }

    public string? Empleado { get; set; }

    public decimal? Meses { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Sueldo { get; set; }

    public decimal? TotalVacaciones { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
