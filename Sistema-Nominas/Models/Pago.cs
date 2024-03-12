using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Pago
{
    public int IdPagos { get; set; }

    public string? Empleado { get; set; }

    public decimal? Salario { get; set; }

    public decimal? Bonificacion { get; set; }

    public decimal? IgssEmpleado { get; set; }

    public decimal? SalarioDevengado { get; set; }

    public decimal? CuotaPatronal { get; set; }

    public decimal? TotalEmpleado { get; set; }

    public decimal? TotalPatronal { get; set; }

    public decimal? SalarioQuincenal { get; set; }

    public decimal? BonificacionQuincenal { get; set; }

    public decimal? IgssEmpleadoQuincenal { get; set; }

    public decimal? SalarioDevengadoQuincenal { get; set; }

    public decimal? IgssPatronalQuincenal { get; set; }

    public decimal? TotalEmpleadoQuincenal { get; set; }

    public decimal? TotalPatronalQuincenal { get; set; }

    public string? TipoPago { get; set; }

    public string? Estado { get; set; }
}
