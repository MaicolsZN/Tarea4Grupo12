using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PracticaEntityGrupo12.Models
{
    public partial class PracticaEntityContext : DbContext
    {
        public PracticaEntityContext()
        {
        }

        public PracticaEntityContext(DbContextOptions<PracticaEntityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-NRF4K2N;database=PracticaEntity;user id=grupo12;password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.CodigoEmpleado)
                    .HasName("PK__Empleado__324FED7316790F02");

                entity.ToTable("Empleado", "dbo");

                entity.Property(e => e.FechaIngresoEmpleado)
                    .HasColumnType("date")
                    .HasColumnName("fechaIngresoEmpleado");

                entity.Property(e => e.NombreEmpleado)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalarioEmpleado).HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
