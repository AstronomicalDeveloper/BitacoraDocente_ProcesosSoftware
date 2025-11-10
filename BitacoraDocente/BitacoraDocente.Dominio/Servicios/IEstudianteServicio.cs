using BitacoraDocente.Intercambio.Dto;
using BitacoraDocente.Intercambio.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitacoraDocente.Dominio.Servicios
{
    public interface IEstudianteServicio
    {
        Task<ResultadoOperacion<EstudianteDto>> ObtenerAsync(int id);
        Task<ResultadoOperacion<List<EstudianteDto>>> ListarAsync();
        Task<ResultadoOperacion<EstudianteDto>> AgregarAsync(EstudianteDto dto);
        Task<ResultadoOperacion<EstudianteDto>> ModificarAsync(int id, EstudianteDto dto);
        Task<ResultadoOperacion<bool>> EliminarAsync(int id);
    }
}
