namespace Sistema_Nomina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pagos
    {
        [Key]
        public int id_pagos { get; set; }

        public int? id_empleado { get; set; }

        public decimal? salario { get; set; }

        public decimal? igss { get; set; }

        public decimal? bonificacion { get; set; }

        public decimal? liquido { get; set; }

        public int? id_tipo_pago { get; set; }

        public int? id_status { get; set; }

        
    }
}
