using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sistema_Nominas.Config;

namespace Sistema_Nominas.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aguinaldo> Aguinaldos { get; set; }

    public virtual DbSet<Bono14> Bono14s { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Indemizacion> Indemizacions { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<Vacacione> Vacaciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle(Conexion.Instance.cadenaConexion);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("NOMINA")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Aguinaldo>(entity =>
        {
            entity.HasKey(e => e.IdAguinaldo).HasName("SYS_C007455");

            entity.ToTable("AGUINALDO");

            entity.Property(e => e.IdAguinaldo)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_AGUINALDO");
            entity.Property(e => e.Dias)
                .HasColumnType("NUMBER")
                .HasColumnName("DIAS");
            entity.Property(e => e.Empleado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPLEADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Meses)
                .HasColumnType("NUMBER")
                .HasColumnName("MESES");
            entity.Property(e => e.Salario)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
            entity.Property(e => e.TotalAguinaldo)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_AGUINALDO");
        });

        modelBuilder.Entity<Bono14>(entity =>
        {
            entity.HasKey(e => e.IdBono14).HasName("SYS_C007453");

            entity.ToTable("BONO14");

            entity.Property(e => e.IdBono14)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_BONO14");
            entity.Property(e => e.Dias)
                .HasColumnType("NUMBER")
                .HasColumnName("DIAS");
            entity.Property(e => e.Empleado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPLEADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Meses)
                .HasColumnType("NUMBER")
                .HasColumnName("MESES");
            entity.Property(e => e.Salario)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
            entity.Property(e => e.TotalBono14)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_BONO14");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("SYS_C007449");

            entity.ToTable("EMPLEADO");

            entity.Property(e => e.IdEmpleado)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_EMPLEADO");
            entity.Property(e => e.Avenida)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("AVENIDA");
            entity.Property(e => e.Calle)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Correo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Empresa)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPRESA");
            entity.Property(e => e.Nit)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("PRIMER_APELLIDO");
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("PRIMER_NOMBRE");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("SEGUNDO_APELLIDO");
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("SEGUNDO_NOMBRE");
            entity.Property(e => e.Telefono)
                .HasColumnType("NUMBER")
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Zona)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa).HasName("SYS_C007447");

            entity.ToTable("EMPRESA");

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.Avenida)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("AVENIDA");
            entity.Property(e => e.Calle)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CALLE");
            entity.Property(e => e.Correo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Nit)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasColumnType("NUMBER")
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Zona)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ZONA");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("SYS_C007475");

            entity.ToTable("ESTADO");

            entity.Property(e => e.IdStatus)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_STATUS");
            entity.Property(e => e.Status)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Indemizacion>(entity =>
        {
            entity.HasKey(e => e.IdIndemizacion).HasName("SYS_C007457");

            entity.ToTable("INDEMIZACION");

            entity.Property(e => e.IdIndemizacion)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_INDEMIZACION");
            entity.Property(e => e.Anos)
                .HasColumnType("NUMBER")
                .HasColumnName("AÑOS");
            entity.Property(e => e.Dias)
                .HasColumnType("NUMBER")
                .HasColumnName("DIAS");
            entity.Property(e => e.Empleado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPLEADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Meses)
                .HasColumnType("NUMBER")
                .HasColumnName("MESES");
            entity.Property(e => e.Salario)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
            entity.Property(e => e.TotalIndemizacion)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_INDEMIZACION");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPagos).HasName("SYS_C007459");

            entity.ToTable("PAGOS");

            entity.Property(e => e.IdPagos)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_PAGOS");
            entity.Property(e => e.Bonificacion)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("BONIFICACION");
            entity.Property(e => e.BonificacionQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("BONIFICACION_QUINCENAL");
            entity.Property(e => e.CuotaPatronal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("CUOTA_PATRONAL");
            entity.Property(e => e.Empleado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPLEADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.IgssEmpleado)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("IGSS_EMPLEADO");
            entity.Property(e => e.IgssEmpleadoQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("IGSS_EMPLEADO_QUINCENAL");
            entity.Property(e => e.IgssPatronalQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("IGSS_PATRONAL_QUINCENAL");
            entity.Property(e => e.Salario)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO");
            entity.Property(e => e.SalarioDevengado)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO_DEVENGADO");
            entity.Property(e => e.SalarioDevengadoQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO_DEVENGADO_QUINCENAL");
            entity.Property(e => e.SalarioQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SALARIO_QUINCENAL");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
            entity.Property(e => e.TotalEmpleado)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_EMPLEADO");
            entity.Property(e => e.TotalEmpleadoQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_EMPLEADO_QUINCENAL");
            entity.Property(e => e.TotalPatronal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_PATRONAL");
            entity.Property(e => e.TotalPatronalQuincenal)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_PATRONAL_QUINCENAL");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoPago).HasName("SYS_C007473");

            entity.ToTable("TIPO_PAGO");

            entity.Property(e => e.IdTipoPago)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_TIPO_PAGO");
            entity.Property(e => e.TipoPago1)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
        });

        modelBuilder.Entity<Vacacione>(entity =>
        {
            entity.HasKey(e => e.IdVacaciones).HasName("SYS_C007451");

            entity.ToTable("VACACIONES");

            entity.Property(e => e.IdVacaciones)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_VACACIONES");
            entity.Property(e => e.Dias)
                .HasColumnType("NUMBER")
                .HasColumnName("DIAS");
            entity.Property(e => e.Empleado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("EMPLEADO");
            entity.Property(e => e.Estado)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Meses)
                .HasColumnType("NUMBER")
                .HasColumnName("MESES");
            entity.Property(e => e.Sueldo)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("SUELDO");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TIPO_PAGO");
            entity.Property(e => e.TotalVacaciones)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("TOTAL_VACACIONES");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
