namespace Sistema_Nomina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estado")]
    public partial class estado
    {
        

        [Key]
        public int id_status { get; set; }

        [StringLength(2000)]
        public string tipo_status { get; set; }

        
    }
}
