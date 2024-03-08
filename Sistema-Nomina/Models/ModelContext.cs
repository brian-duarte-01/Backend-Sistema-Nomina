using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sistema_Nomina.Config;

namespace Sistema_Nomina.Models;

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

    public virtual DbSet<Indemizacion> Indemizacions { get; set; }

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

        modelBuilder.Entity<Indemizacion>(entity =>
        {
            entity.HasKey(e => e.IdIndemizacion).HasName("SYS_C007457");

            entity.ToTable("INDEMIZACION");

            entity.Property(e => e.IdIndemizacion)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID_INDEMIZACION");
            entity.Property(e => e.Años)
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
