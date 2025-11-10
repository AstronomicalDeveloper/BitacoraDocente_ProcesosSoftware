using BitacoraDocente.Dominio.Extensiones;
using BitacoraDocente.Intercambio.Dto;
using BitacoraDocente.Intercambio.Dto.General;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Servicios.Implementacion
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly AppDbContext _context;

        // Inyectando el DbSet<Estudiante> para acceder a la base de datos.
        public EstudianteServicio(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResultadoOperacion<EstudianteDto>> AgregarAsync(EstudianteDto dto)
        {
            try
            {
                if (dto == null)
                {
                    return ResultadoOperacion<EstudianteDto>.SetError("El dto es nulo.");
                }

                var entidad = dto.toEntidad();

                //Validando mi entidad.
                var validacion = entidad.Validar();
                if (!validacion.Exito)
                {
                    return ResultadoOperacion<EstudianteDto>.SetError(validacion.Mensaje);
                }

                //Verificando si exite la razón social
                var existe = await _context.Estudiantes.Where(e => e.NumeroDocumento == entidad.NumeroDocumento).ToListAsync();
                if (existe.Any())
                {
                    return ResultadoOperacion<EstudianteDto>.SetError("El estudiante con este numero de documento ya existe.");
                }

                //Guardando mi entidad.
                await _context.Estudiantes.AddAsync(entidad);
                await _context.SaveChangesAsync();

                //Retornando el dto.
                dto = entidad.toDto();
                return ResultadoOperacion<EstudianteDto>.SetExito(dto);

            }
            catch (Exception ex)
            {
                return ResultadoOperacion<EstudianteDto>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<bool>> EliminarAsync(int id)
        {
            try
            {
                //Recupero de la BD.
                var entidad = await _context.Estudiantes.FindAsync(id);

                if (entidad == null)
                {
                    return ResultadoOperacion<bool>.SetError($"No se encontró el estudiante con {id}");
                }

                // Verificar si no tiene hijos.
                // bool tieneRelacionados = await _context.Desempenios.AnyAsync(x => x.EstudianteId == id); (proximamente...)
                bool tieneRelacionados = false; // por el momento, se queda en false.

                if (tieneRelacionados)
                {
                    return ResultadoOperacion<bool>.SetError("Este estudiante tiene elementos relacionados. No se puede eliminar.");
                }

                //Elimino el registro.
                _context.Estudiantes.Remove(entidad);
                await _context.SaveChangesAsync();

                return ResultadoOperacion<bool>.SetExito(true);

            }
            catch (Exception ex)
            {
                return ResultadoOperacion<bool>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<List<EstudianteDto>>> ListarAsync()
        {
            try
            {
                var lista = await _context.Estudiantes.ToListAsync();
                var listaDto = lista.Select(x => x.toDto()).ToList();
                return ResultadoOperacion<List<EstudianteDto>>.SetExito(listaDto);

            }
            catch (Exception ex)
            {
                return ResultadoOperacion<List<EstudianteDto>>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<EstudianteDto>> ModificarAsync(int id, EstudianteDto dto)
        {
            try
            {
                var entidad = await _context.Estudiantes.FindAsync(id);

                if (entidad == null)
                {
                    return ResultadoOperacion<EstudianteDto>.SetError($"No se encontró el cliente con {id}");
                }

                //Asignamos los nuevos valores.
                entidad = dto.toEntidadEnModificacion(entidad);

                //Validando mi entidad.
                var validacion = entidad.Validar();
                if (!validacion.Exito)
                {
                    return ResultadoOperacion<EstudianteDto>.SetError(validacion.Mensaje);
                }

                //Busco un duplicado.
                var existe = await _context.Estudiantes.Where(e => e.NumeroDocumento == entidad.NumeroDocumento && e.EstudianteId != id).ToListAsync();
                if (existe.Any())
                {
                    return ResultadoOperacion<EstudianteDto>.SetError("El estudiante con este numero de documento ya existe.");
                }


                //Actualizo y salvo los cambios.
                _context.Estudiantes.Update(entidad);
                await _context.SaveChangesAsync();

                return ResultadoOperacion<EstudianteDto>.SetExito(entidad.toDto());

            }
            catch (Exception ex)
            {
                return ResultadoOperacion<EstudianteDto>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<EstudianteDto>> ObtenerAsync(int id)
        {
            try
            {
                //Leyendo la entidad desde el repositorio (DB)
                var entidad = await _context.Estudiantes.FindAsync(id);
                if (entidad == null)
                {
                    return ResultadoOperacion<EstudianteDto>.SetError($"Estudiante con ID {id} no encontrado.");
                }

                //Mapeo mi dto
                var dto = entidad.toDto();

                //Retorno mi dto
                return ResultadoOperacion<EstudianteDto>.SetExito(dto);

            }
            catch (Exception ex)
            {
                return ResultadoOperacion<EstudianteDto>.SetError(ex.Message);
            }
        }
    }
}
