using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Config;

namespace WebApplication2.Models;

public partial class CrudNotasContext : DbContext
{
    public CrudNotasContext()
    {
    }

    public CrudNotasContext(DbContextOptions<CrudNotasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Notum> Nota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Conexion.Instance.cadenaCorrecta);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__nota__3213E83F437BF4A5");

            entity.ToTable("nota");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nota1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("nota1");
            entity.Property(e => e.Nota2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("nota2");
            entity.Property(e => e.Resultado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("resultado");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
