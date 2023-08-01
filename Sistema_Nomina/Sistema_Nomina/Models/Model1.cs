using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sistema_Nomina.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipo_pago> tipo_pago { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<empleado>()
                .Property(e => e.primer_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.segundo_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.primer_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.segundo_apellido)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.nit)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.avenida)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.avenida)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.zona)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.nit)
                .IsUnicode(false);

            modelBuilder.Entity<empresa>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .Property(e => e.tipo_status)
                .IsUnicode(false);

            modelBuilder.Entity<pagos>()
                .Property(e => e.salario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<pagos>()
                .Property(e => e.igss)
                .HasPrecision(10, 2);

            modelBuilder.Entity<pagos>()
                .Property(e => e.bonificacion)
                .HasPrecision(10, 2);

            modelBuilder.Entity<pagos>()
                .Property(e => e.liquido)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tipo_pago>()
                .Property(e => e.tipo_pago1)
                .IsUnicode(false);
        }
    }
}
