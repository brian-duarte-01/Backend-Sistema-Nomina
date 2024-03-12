using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Notum
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Nota1 { get; set; }

    public decimal? Nota2 { get; set; }

    public decimal? Resultado { get; set; }

    public string? Fecha { get; set; }
}
