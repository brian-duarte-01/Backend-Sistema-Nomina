using System;
using System.Collections.Generic;

namespace Sistema_Nominas.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Calle { get; set; }

    public string? Avenida { get; set; }

    public string? Zona { get; set; }

    public decimal? Telefono { get; set; }

    public string? Nit { get; set; }

    public string? Correo { get; set; }
}
