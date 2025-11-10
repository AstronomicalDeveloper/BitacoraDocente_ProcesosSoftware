using BitacoraDocente.Dominio.Modelo;
using BitacoraDocente.Intercambio.Dto;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Extensiones
{
    public static class EstudianteExtension
    {
        public static EstudianteDto toDto(this Estudiante entidad)
        {
            EstudianteDto dto = new EstudianteDto();

            dto.EstudianteId = entidad.EstudianteId;
            dto.TipoDocumentoDto = new GeneralDto
            {
                Id = (int)entidad.TipoDocumento,
                Nombre = entidad.TipoDocumento.ToString()
            };
            dto.NumeroDocumento = entidad.NumeroDocumento;
            dto.ApellidoPaterno = entidad.ApellidoPaterno;
            dto.ApellidoMaterno = entidad.ApellidoMaterno;
            dto.Nombre = entidad.Nombre;
            dto.FechaNacimiento = entidad.FechaNacimiento;
            dto.Genero = new GeneralDto
            {
                Id = (int)entidad.Genero,
                Nombre = entidad.Genero.ToString()
            };
            dto.NombreTutor = entidad.NombreTutor;
            dto.TelefonoTutor = entidad.TelefonoTutor;

            return dto;
        }

        public static Estudiante toEntidadEnModificacion(this EstudianteDto dto, Estudiante entidad)
        {
            entidad.TipoDocumento = (Comun.Enumeracion.TipoDocumento)dto.TipoDocumentoDto!.Id;
            entidad.NumeroDocumento = dto.NumeroDocumento;
            entidad.ApellidoPaterno = dto.ApellidoPaterno;
            entidad.ApellidoMaterno = dto.ApellidoMaterno;
            entidad.Nombre = dto.Nombre;
            entidad.FechaNacimiento = dto.FechaNacimiento;
            entidad.Genero = (Comun.Enumeracion.TipoGenero)dto.Genero!.Id;
            entidad.NombreTutor = dto.NombreTutor;
            entidad.TelefonoTutor = dto.TelefonoTutor;

            return entidad;
        }

        public static Estudiante toEntidad(this EstudianteDto dto)
        {
            var entidad = new Estudiante();

            entidad.TipoDocumento = (Comun.Enumeracion.TipoDocumento)dto.TipoDocumentoDto!.Id;
            entidad.NumeroDocumento = dto.NumeroDocumento;
            entidad.ApellidoPaterno = dto.ApellidoPaterno;
            entidad.ApellidoMaterno = dto.ApellidoMaterno;
            entidad.Nombre = dto.Nombre;
            entidad.FechaNacimiento = dto.FechaNacimiento;
            entidad.Genero = (Comun.Enumeracion.TipoGenero)dto.Genero!.Id;
            entidad.NombreTutor = dto.NombreTutor;
            entidad.TelefonoTutor = dto.TelefonoTutor;

            return entidad;
        }
    }
}
