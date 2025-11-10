using BitacoraDocente.Dominio.Servicios;
using BitacoraDocente.Intercambio.Dto;
using BitacoraDocente.Intercambio.Dto.General;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitacoraDocente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        //Inyectamos el servicio de cliente
        private readonly IEstudianteServicio _estudianteServicio;

        public EstudianteController(IEstudianteServicio clienteServicio)
        {
            this._estudianteServicio = clienteServicio;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoOperacion<EstudianteDto>>> Obtener(int id)
        {
            try
            {
                var respuesta = await _estudianteServicio.ObtenerAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<EstudianteDto>.SetError(ex.Message));
            }
        }

        [HttpGet("listar")]
        public async Task<ActionResult<ResultadoOperacion<List<EstudianteDto>>>> Listar()
        {
            try
            {
                var respuesta = await _estudianteServicio.ListarAsync();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<List<EstudianteDto>>.SetError(ex.Message));
            }
        }

        [HttpPost]
        public async Task<ActionResult<ResultadoOperacion<EstudianteDto>>> Agregar([FromBody] EstudianteDto dto)
        {
            try
            {
                var respuesta = await _estudianteServicio.AgregarAsync(dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<EstudianteDto>.SetError(ex.Message));
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultadoOperacion<EstudianteDto>>> Modificar(int id, [FromBody] EstudianteDto dto)
        {
            try
            {
                var respuesta = await _estudianteServicio.ModificarAsync(id, dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<EstudianteDto>.SetError(ex.Message));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultadoOperacion<bool>>> Eliminar(int id)
        {
            try
            {
                var respuesta = await _estudianteServicio.EliminarAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<bool>.SetError(ex.Message));
            }
        }
    }
}
