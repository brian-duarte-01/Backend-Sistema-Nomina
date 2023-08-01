namespace Sistema_Nomina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tipo_pago
    {
      
        [Key]
        public int id_tipo_pago { get; set; }

        [Column("tipo_pago")]
        [StringLength(2000)]
        public string tipo_pago1 { get; set; }

     
    }
}
