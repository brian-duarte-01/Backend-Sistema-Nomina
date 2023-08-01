namespace Sistema_Nomina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleado")]
    public partial class empleado
    {
       

        [Key]
        public int id_empleado { get; set; }

        [StringLength(2000)]
        public string primer_nombre { get; set; }

        [StringLength(2000)]
        public string segundo_nombre { get; set; }

        [StringLength(2000)]
        public string primer_apellido { get; set; }

        [StringLength(2000)]
        public string segundo_apellido { get; set; }

        [StringLength(2000)]
        public string nit { get; set; }

        [StringLength(2000)]
        public string calle { get; set; }

        [StringLength(2000)]
        public string avenida { get; set; }

        [StringLength(2000)]
        public string zona { get; set; }

        public int? telefono { get; set; }

        [StringLength(2000)]
        public string correo { get; set; }

        public int? id_empresa { get; set; }

        
    }
}
