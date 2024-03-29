﻿using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Bono14
{
    public int IdBono14 { get; set; }

    public string? Empleado { get; set; }

    public int? Meses { get; set; }

    public int? Dias { get; set; }

    public decimal? Salario { get; set; }

    public decimal? TotalBono14 { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
