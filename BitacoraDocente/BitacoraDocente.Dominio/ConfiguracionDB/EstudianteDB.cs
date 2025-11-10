using BitacoraDocente.Dominio.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.ConfiguracionDB
{
    public class EstudianteDB : IEntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeBuilder<Estudiante> builder)
        {
            builder.ToTable("estudiantes");
            builder.HasKey(e => e.EstudianteId);
            builder.Property(e => e.EstudianteId).HasColumnName("estudiante_id").ValueGeneratedOnAdd();
            builder.Property(e => e.TipoDocumento).HasColumnName("TipoDocumento").IsRequired();
            builder.Property(e => e.NumeroDocumento).HasColumnName("numero_documento").HasMaxLength(20).IsRequired();
            builder.Property(e => e.ApellidoPaterno).HasColumnName("apellido_paterno").HasMaxLength(50).IsRequired();
            builder.Property(e => e.ApellidoMaterno).HasColumnName("apellido_materno").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Nombre).HasColumnName("nombre").HasMaxLength(50).IsRequired();
            builder.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento").IsRequired();
            builder.Property(e => e.Genero).HasColumnName("genero").IsRequired();
            builder.Property(e => e.NombreTutor).HasColumnName("nombre_tutor").HasMaxLength(100).IsRequired();
            builder.Property(e => e.TelefonoTutor).HasColumnName("telefono_tutor").HasMaxLength(15).IsRequired();


        }
    }
}
