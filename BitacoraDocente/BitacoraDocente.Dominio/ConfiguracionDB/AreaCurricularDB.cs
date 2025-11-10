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
    public class AreaCurricularDB : IEntityTypeConfiguration<AreaCurricular>
    {
        public void Configure(EntityTypeBuilder<AreaCurricular> builder)
        {
            builder.ToTable("areas_curriculares");
            builder.HasKey(a => a.AreaCurricularId);
            builder.Property(a => a.AreaCurricularId).HasColumnName("area_curricular_id").ValueGeneratedOnAdd();
            builder.Property(a => a.Nombre).HasColumnName("nombre").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Descripcion).HasColumnName("descripcion").HasMaxLength(250).IsRequired();

            // Creo un index único basado en el nombre del área curricular.
            builder.HasIndex(a => a.Nombre).HasDatabaseName("IX_AreaCurricular_Nombre");

            // Indico que AreaCurricularId es una clave foranea en la entidad Planificacion.
            builder.HasMany(a => a.Planificaciones).WithOne(p => p.AreaCurricular)
                   .HasForeignKey(p => p.AreaCurricularId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
