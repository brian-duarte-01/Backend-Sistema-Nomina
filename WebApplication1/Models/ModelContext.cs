using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Config;

namespace WebApplication1.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Notum> Nota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle(Conexion.Instance.cadenaConexion);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("PRUEBA")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C007445");

            entity.ToTable("NOTA");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(38)")
                .HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Nombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Nota1)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("NOTA1");
            entity.Property(e => e.Nota2)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("NOTA2");
            entity.Property(e => e.Resultado)
                .HasColumnType("NUMBER(10,2)")
                .HasColumnName("RESULTADO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
