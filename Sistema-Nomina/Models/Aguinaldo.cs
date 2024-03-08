using System;
using System.Collections.Generic;

namespace Sistema_Nomina.Models;

public partial class Aguinaldo
{
    public int IdAguinaldo { get; set; }

    public string? Empleado { get; set; }

    public decimal? Meses { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Salario { get; set; }

    public decimal? TotalAguinaldo { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
