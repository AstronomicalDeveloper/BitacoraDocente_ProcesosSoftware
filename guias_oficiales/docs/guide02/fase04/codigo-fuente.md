## Código fuente

## Código Fuente

---

# 1. BACKEND — RUTINAS ESENCIALES

### 1.1. `CompetenciaController.cs`
**Ubicación:** `backend/BitacoraDocente.API/Controllers/CompetenciaController.cs`  
**Función:** Punto de entrada (API) para gestionar competencias educativas.

**Para qué sirve:**
- Expone métodos HTTP estándar (GET, POST, PUT, DELETE) para CRUD.
- Utiliza `ICompetenciaServicio` para delegar la lógica de negocio.
- Envuelve las respuestas en `ResultadoOperacion<T>` para estandarizar resultados ante el frontend.

```
  namespace BitacoraDocente.API.Controllers
  {
      [Route("api/[controller]")]
      [ApiController]
      public class CompetenciaController : ControllerBase
    {
        private readonly ICompetenciaServicio _competenciaServicio;

        public CompetenciaController(ICompetenciaServicio competenciaServicio)
        {
            _competenciaServicio = competenciaServicio;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoOperacion<CompetenciaDto>>> Obtener(int id)
        {
            try
            {
                var respuesta = await _competenciaServicio.ObtenerAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<CompetenciaDto>.SetError(ex.Message));
            }
        }

        [HttpGet("listar")]
        public async Task<ActionResult<ResultadoOperacion<List<CompetenciaDto>>>> Listar()
        {
            try
            {
                var respuesta = await _competenciaServicio.ListarAsync();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<List<CompetenciaDto>>.SetError(ex.Message));
            }
        }

        [HttpPost]
        public async Task<ActionResult<ResultadoOperacion<CompetenciaDto>>> Agregar([FromBody] CompetenciaDto dto)
        {
            try
            {
                var respuesta = await _competenciaServicio.AgregarAsync(dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<CompetenciaDto>.SetError(ex.Message));
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultadoOperacion<CompetenciaDto>>> Modificar(int id, [FromBody] CompetenciaDto dto)
        {
            try
            {
                var respuesta = await _competenciaServicio.ModificarAsync(id, dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<CompetenciaDto>.SetError(ex.Message));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultadoOperacion<bool>>> Eliminar(int id)
        {
            try
            {
                var respuesta = await _competenciaServicio.EliminarAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<bool>.SetError(ex.Message));
            }
        }
    }
```
---

### 1.2. `SesionController.cs`
**Ubicación:** `backend/BitacoraDocente.API/Controllers/SesionController.cs`  
**Función:** Controla las sesiones de aprendizaje (clases diarias).

**Para qué sirve:**
- Registra qué se enseña en una fecha específica.
- Vincula una sesión con una Unidad Didáctica y Competencia.
- Define el propósito pedagógico y fecha de la clase.

```
   namespace BitacoraDocente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SesionController : ControllerBase
    {
        private readonly ISesionServicio _sesionServicio;

        public SesionController(ISesionServicio sesionServicio)
        {
            _sesionServicio = sesionServicio;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoOperacion<SesionDto>>> Obtener(int id)
        {
            try
            {
                var respuesta = await _sesionServicio.ObtenerAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<SesionDto>.SetError(ex.Message));
            }
        }

        [HttpGet("listar/{unidadDidacticaId}")]
        public async Task<ActionResult<ResultadoOperacion<List<SesionDto>>>> Listar(int unidadDidacticaId)
        {
            try
            {
                var respuesta = await _sesionServicio.ListarAsync(unidadDidacticaId);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<List<SesionDto>>.SetError(ex.Message));
            }
        }

        [HttpPost]
        public async Task<ActionResult<ResultadoOperacion<SesionDto>>> Agregar([FromBody] SesionDto dto)
        {
            try
            {
                var respuesta = await _sesionServicio.AgregarAsync(dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<SesionDto>.SetError(ex.Message));
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultadoOperacion<SesionDto>>> Modificar(int id, [FromBody] SesionDto dto)
        {
            try
            {
                var respuesta = await _sesionServicio.ModificarAsync(id, dto);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<SesionDto>.SetError(ex.Message));
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultadoOperacion<bool>>> Eliminar(int id)
        {
            try
            {
                var respuesta = await _sesionServicio.EliminarAsync(id);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<bool>.SetError(ex.Message));
            }
        }
    }
}
```
---

### 1.3. `EstudianteController.cs` + `EstudianteServicio.cs`
**Ubicación:**  
`backend/.../EstudianteController.cs`  
`backend/.../EstudianteServicio.cs`  

Es una de las partes más robustas del sistema.

#### `EstudianteController.cs`
- Gestiona el registro de alumnos (datos personales, tutor, etc.).
- Contiene endpoints analíticos como:
  - `GetNotasActuales`
  - `GetAsistenciaResumen`

```
   namespace BitacoraDocente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        //Inyectamos el servicio de cliente
        private readonly IEstudianteServicio _estudianteServicio;

        public EstudianteController(IEstudianteServicio estudianteServicio)
        {
            this._estudianteServicio = estudianteServicio;
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

        [HttpGet("listar/activos")]
        public async Task<ActionResult<ResultadoOperacion<List<EstudianteDto>>>> ListarActivos()
        {
            try
            {
                var respuesta = await _estudianteServicio.ListarActivosAsync();
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return Ok(ResultadoOperacion<List<EstudianteDto>>.SetError(ex.Message));
            }
        }

        [HttpGet("listar/todo")]
        public async Task<ActionResult<ResultadoOperacion<List<EstudianteDto>>>> ListarTodo()
        {
            try
            {
                var respuesta = await _estudianteServicio.ListarTodoAsync();
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

        [HttpGet("{id}/notas/anual")]
        public async Task<ActionResult<NotasAnualesDto>> GetNotasActuales(int id)
        {
            int anio = DateTime.Now.Year;

            var dto = await _estudianteServicio.ObtenerNotasPorAnioAsync(id, anio);

            return Ok(dto);
        }

        [HttpGet("{id}/notas/anual/{anio}")]
        public async Task<ActionResult<NotasAnualesDto>> GetNotasPorAnio(int id, int anio)
        {
            var dto = await _estudianteServicio.ObtenerNotasPorAnioAsync(id, anio);

            return Ok(dto);
        }

        [HttpGet("{estudianteId}/asistencia/actual")]
        public async Task<ActionResult<EstudianteResumenDto>> GetResumenActual(int estudianteId)
        {
            int anio = DateTime.Now.Year;

            var dto = await _estudianteServicio.ObtenerAsistenciaDelAnioAsync(estudianteId, anio);

            return Ok(dto);
        }

        [HttpGet("{id}/asistencia/{anioEscolar}")]
        public async Task<ActionResult<AsistenciaResumenDto>> GetAsistenciaResumen(int id, int anioEscolar)
        {
            var dto = await _estudianteServicio.ObtenerAsistenciaDelAnioAsync(id, anioEscolar);
            return Ok(dto);
        }
    }
}
```

#### `EstudianteServicio.cs` — Lógica de negocio
- Validación: evita duplicidad del número de documento.
- Algoritmo crítico: `CalcularNotaBimestre`
  - Calcula la nota según capacidades logradas vs evaluadas.
  - Maneja asistencia injustificada y su impacto en notas.
- Conversión numérica a cualitativa: transforma 0–100 en A, B, C.

```
   using BitacoraDocente.Comun.Enumeracion;
using BitacoraDocente.Dominio.Extensiones;
using BitacoraDocente.Dominio.Modelo;
using BitacoraDocente.Intercambio.Dto;
using BitacoraDocente.Intercambio.Dto.Funcionalidades;
using BitacoraDocente.Intercambio.Dto.General;
using Microsoft.EntityFrameworkCore;

namespace BitacoraDocente.Dominio.Servicios.Implementacion
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly AppDbContext _context;

        public EstudianteServicio(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResultadoOperacion<EstudianteDto>> AgregarAsync(EstudianteDto dto)
        {
            try
            {
                if (dto == null)
                    return ResultadoOperacion<EstudianteDto>.SetError("El dto es nulo.");

                var entidad = dto.toEntidad();

                var validacion = entidad.Validar();
                if (!validacion.Exito)
                    return ResultadoOperacion<EstudianteDto>.SetError(validacion.Mensaje);

                var existe = await _context.Estudiantes
                    .AnyAsync(e => e.NumeroDocumento == entidad.NumeroDocumento);

                if (existe)
                    return ResultadoOperacion<EstudianteDto>.SetError("El estudiante con este número de documento ya existe.");

                await _context.Estudiantes.AddAsync(entidad);
                await _context.SaveChangesAsync();

                dto = entidad.toDto();
                return ResultadoOperacion<EstudianteDto>.SetExito(dto);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<EstudianteDto>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<EstudianteDto>> ModificarAsync(int id, EstudianteDto dto)
        {
            try
            {
                var entidad = await _context.Estudiantes.FindAsync(id);

                if (entidad == null)
                    return ResultadoOperacion<EstudianteDto>.SetError($"No se encontró el cliente con {id}");

                entidad = dto.toEntidadEnModificacion(entidad);

                var validacion = entidad.Validar();
                if (!validacion.Exito)
                    return ResultadoOperacion<EstudianteDto>.SetError(validacion.Mensaje);

                var existe = await _context.Estudiantes
                    .AnyAsync(e => e.NumeroDocumento == entidad.NumeroDocumento && e.EstudianteId != id);

                if (existe)
                    return ResultadoOperacion<EstudianteDto>.SetError("El estudiante con este número de documento ya existe.");

                _context.Estudiantes.Update(entidad);
                await _context.SaveChangesAsync();

                return ResultadoOperacion<EstudianteDto>.SetExito(entidad.toDto());
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
                var entidad = await _context.Estudiantes.FindAsync(id);

                if (entidad == null)
                    return ResultadoOperacion<bool>.SetError($"No se encontró el estudiante con {id}");

                bool tieneRelacionados = await _context.Desempenios.AnyAsync(x => x.EstudianteId == id);

                if (tieneRelacionados)
                    return ResultadoOperacion<bool>.SetError("Este estudiante tiene elementos relacionados. No se puede eliminar.");

                _context.Estudiantes.Remove(entidad);
                await _context.SaveChangesAsync();

                return ResultadoOperacion<bool>.SetExito(true);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<bool>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<List<EstudianteDto>>> ListarActivosAsync()
        {
            try
            {
                var lista = await _context.Estudiantes.Where(e => e.EstaActivo == true).ToListAsync();
                var listaDto = lista.Select(x => x.toDto()).ToList();
                return ResultadoOperacion<List<EstudianteDto>>.SetExito(listaDto);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<List<EstudianteDto>>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<List<EstudianteDto>>> ListarTodoAsync()
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

        public async Task<ResultadoOperacion<EstudianteDto>> ObtenerAsync(int id)
        {
            try
            {
                var entidad = await _context.Estudiantes.FindAsync(id);

                if (entidad == null)
                    return ResultadoOperacion<EstudianteDto>.SetError($"Estudiante con ID {id} no encontrado.");

                return ResultadoOperacion<EstudianteDto>.SetExito(entidad.toDto());
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<EstudianteDto>.SetError(ex.Message);
            }
        }
        private (DateOnly Inicio, DateOnly Fin) RangoBimestre(int anio, int bimestre)
        {
            return bimestre switch
            {
                1 => (new DateOnly(anio, 1, 1), new DateOnly(anio, 3, 31)),
                2 => (new DateOnly(anio, 4, 1), new DateOnly(anio, 6, 30)),
                3 => (new DateOnly(anio, 7, 1), new DateOnly(anio, 9, 30)),
                4 => (new DateOnly(anio, 10, 1), new DateOnly(anio, 12, 31)),
                _ => throw new ArgumentOutOfRangeException(nameof(bimestre))
            };
        }

        private string ConvertirPorcentajeALetra(double porcentaje)
        {
            if (porcentaje >= 67) return "A";
            if (porcentaje >= 34) return "B";
            return "C";
        }

        private string CalcularNotaBimestre(IEnumerable<Sesion> sesiones, int estudianteId)
        {
            int totalCap = 0;
            int capLogradas = 0;

            foreach (var sesion in sesiones)
            {
                // asistencia
                var asistencia = sesion.Asistencias.FirstOrDefault(a => a.EstudianteId == estudianteId);
                bool falto = asistencia == null ||
                             asistencia.Estado == TipoAsistencia.FALTA ||
                             asistencia.Estado == TipoAsistencia.FALTA_JUSTIFICADA;

                // solo tomar desempenios evaluados
                var evaluados = sesion.Desempenios
                    .Where(d => d.EstudianteId == estudianteId && d.EstaLogrado != null)
                    .ToList();

                if (evaluados.Count == 0)
                    continue;

                totalCap += evaluados.Count;

                if (!falto)
                    capLogradas += evaluados.Count(d => d.EstaLogrado == true);
            }

            if (totalCap == 0)
                return "--";

            double porcentaje = (capLogradas * 100.0) / totalCap;
            return ConvertirPorcentajeALetra(porcentaje);
        }

        public async Task<NotaResumenDto> ObtenerNotasPorAreaYAnioAsync(int estudianteId, int areaCurricularId, int anioEscolar)
        {
            var resumen = new NotaResumenDto();

            var planificacion = await _context.Planificaciones
                .Where(p => p.AreaCurricularId == areaCurricularId && p.AnioEscolar == anioEscolar)
                .Include(p => p.UnidadesDidacticas)
                    .ThenInclude(u => u.Sesiones)
                        .ThenInclude(s => s.Desempenios)
                .Include(p => p.UnidadesDidacticas)
                    .ThenInclude(u => u.Sesiones)
                        .ThenInclude(s => s.Asistencias)
                .FirstOrDefaultAsync();

            if (planificacion == null)
                return resumen;

            for (int b = 1; b <= 4; b++)
            {
                var (ini, fin) = RangoBimestre(anioEscolar, b);

                var sesiones = planificacion.UnidadesDidacticas
                    .SelectMany(u => u.Sesiones)
                    .Where(s => s.Fecha >= ini && s.Fecha <= fin)
                    .ToList();

                string nota = CalcularNotaBimestre(sesiones, estudianteId);

                resumen.Detalle.Add(new NotaDetalleDto
                {
                    Bimestre = b,
                    Nota = nota
                });
            }

            // último bimestre con nota válida
            resumen.PromedioFinal =
                resumen.Detalle.LastOrDefault(d => d.Nota != "--")?.Nota ?? "--";

            return resumen;
        }

        public async Task<ResultadoOperacion<NotasAnualesDto>> ObtenerNotasPorAnioAsync(int estudianteId, int anioEscolar)
        {
            try
            {
                var resultado = new NotasAnualesDto
                {
                    AnioEscolar = anioEscolar
                };

                var planificaciones = await _context.Planificaciones
                    .Where(p => p.AnioEscolar == anioEscolar)
                    .Include(p => p.AreaCurricular)
                    .Include(p => p.UnidadesDidacticas)
                        .ThenInclude(u => u.Sesiones)
                            .ThenInclude(s => s.Desempenios)
                    .Include(p => p.UnidadesDidacticas)
                        .ThenInclude(u => u.Sesiones)
                            .ThenInclude(s => s.Asistencias)
                    .ToListAsync();

                foreach (var plan in planificaciones)
                {
                    var notaResumen = new NotaResumenDto();

                    for (int b = 1; b <= 4; b++)
                    {
                        var (ini, fin) = RangoBimestre(anioEscolar, b);

                        var sesiones = plan.UnidadesDidacticas
                            .SelectMany(u => u.Sesiones)
                            .Where(s => s.Fecha >= ini && s.Fecha <= fin)
                            .ToList();

                        string nota = CalcularNotaBimestre(sesiones, estudianteId);

                        notaResumen.Detalle.Add(new NotaDetalleDto
                        {
                            Bimestre = b,
                            Nota = nota
                        });
                    }

                    notaResumen.PromedioFinal =
                        notaResumen.Detalle.LastOrDefault(d => d.Nota != "--")?.Nota ?? "--";

                    resultado.Planificaciones.Add(new NotaPlanificacionDto
                    {
                        PlanificacionId = plan.PlanificacionId,
                        AreaCurricular = plan.AreaCurricular.Nombre,
                        Nota = notaResumen
                    });
                }

                return ResultadoOperacion<NotasAnualesDto>.SetExito(resultado);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<NotasAnualesDto>.SetError(ex.Message);
            }
        }

        public async Task<ResultadoOperacion<AsistenciaResumenDto>> ObtenerAsistenciaDelAnioAsync(int estudianteId, int anioEscolar)
        {
            try
            {
                var resumen = new AsistenciaResumenDto();

                var planificaciones = await _context.Planificaciones
                    .Where(p => p.AnioEscolar == anioEscolar)
                    .Include(p => p.UnidadesDidacticas)
                        .ThenInclude(u => u.Sesiones)
                            .ThenInclude(s => s.Asistencias)
                    .ToListAsync();

                var sesiones = planificaciones
                    .SelectMany(p => p.UnidadesDidacticas)
                    .SelectMany(u => u.Sesiones)
                    .ToList();

                resumen.TotalSesiones = sesiones.Count;

                foreach (var sesion in sesiones)
                {
                    // ahora tomamos TODAS las asistencias del estudiante
                    var asistenciasEst = sesion.Asistencias
                        .Where(a => a.EstudianteId == estudianteId)
                        .ToList();

                    if (asistenciasEst.Count == 0)
                    {
                        resumen.SinAsitencia++;
                        continue;
                    }

                    foreach (var a in asistenciasEst)
                    {
                        switch (a.Estado)
                        {
                            case TipoAsistencia.ASISTIO:
                                resumen.Asistencias++;
                                break;

                            case TipoAsistencia.TARDANZA:
                                resumen.Tardanzas++;
                                break;

                            case TipoAsistencia.TARDANZA_JUSTIFICADA:
                                resumen.TardanzasJustificadas++;
                                break;

                            case TipoAsistencia.FALTA:
                                resumen.Faltas++;
                                break;

                            case TipoAsistencia.FALTA_JUSTIFICADA:
                                resumen.FaltasJustificadas++;
                                break;

                            default:
                                resumen.SinAsitencia++;
                                break;
                        }
                    }
                }

                if (resumen.TotalSesiones > 0)
                {
                    resumen.PorcentajeAsistencia =
                        (double)resumen.Asistencias * 100.0 / resumen.TotalSesiones;

                    resumen.PorcentajeFalta =
                        (double)(resumen.Faltas + resumen.FaltasJustificadas) * 100.0
                        / resumen.TotalSesiones;
                }

                return ResultadoOperacion<AsistenciaResumenDto>.SetExito(resumen);
            }
            catch (Exception ex)
            {
                return ResultadoOperacion<AsistenciaResumenDto>.SetError(ex.Message);
            }
        }
    }
}
```
---

### 1.4. Lógica de Notas (dentro de `EstudianteServicio.cs`)
**Función principal:** `ObtenerNotasPorAnioAsync`

**Para qué sirve:**
- Recorre planificaciones del año escolar.
- Ubica sesiones, evaluaciones y desempeños.
- Genera reportes anuales por competencias y bimestres.
- Es el componente que transforma datos en libreta escolar.

---

### 1.5. `PlanificacionController.cs`
**Ubicación:** `backend/BitacoraDocente.API/Controllers/PlanificacionController.cs`  
**Función:** Gestiona la estructura macro del curso.

**Para qué sirve:**
- Conecta Año Escolar con Área Curricular.
- Sin planificación no existen unidades ni sesiones.
- Expone CRUD para crear estructuras pedagógicas.

---

### 1.6. DTOs Claves (Data Transfer Objects)
**Ubicación:** `backend/BitacoraDocente.Intercambio/Dto/...`

#### Principales DTOs:
- `CompetenciaDto`: nombre, descripción, transversalidad.
- `SesionDto`: título, fecha, propósito, IDs vinculados.
- `EstudianteDto`: identificación, tutor, estado activo.
- `NotaDetalleDto`: bimestre y nota cualitativa (A/B/C).

### 1.7. Entidades del modelo.
- `Estudiante.cs`

```
   public class Estudiante
  {
      public int EstudianteId { get; set; }
      public TipoDocumento TipoDocumento { get; set; }
      public string NumeroDocumento { get; set; } = string.Empty;
      public string ApellidoPaterno { get; set; } = string.Empty;
      public string ApellidoMaterno { get; set; } = string.Empty;
      public string Nombre { get; set; } = string.Empty;
      public DateOnly FechaNacimiento { get; set; }
      public TipoGenero Genero { get; set; }
      public string NombreTutor { get; set; } = string.Empty;
      public string TelefonoTutor { get; set; } = string.Empty;
      public bool EstaActivo { get; set; }
  
      public ICollection<Asistencia> Asistencias { get; set; } = new List<Asistencia>();
      public ICollection<Desempenio> Desempenios { get; set; } = new List<Desempenio>();
      public ICollection<Observacion> Observaciones { get; set; } = new List<Observacion>();
  
      public ResultadoOperacion<bool> Validar()
      {
          var respuesta = EntidadValidador.ValidarCamposRequeridos(this);
          return respuesta;
      }
  }
```
---

# 2. FRONTEND — HOOKS Y SERVICIOS

### 2.1. Hooks Importantes

#### `useCompetenciasList` (`useCompetencia.ts`)
**Ubicación:** `frontend/src/features/competencia/hooks/useCompetencia.ts`  
**Estado:** actualmente usa datos falsos para desarrollo.  
**Nota:** en versión final debe conectarse a React Query.

---

#### `usePlanificacionesList` y `usePlanificacionDetail`
**Ubicación:** `frontend/src/features/planificacion/hooks/usePlanificacion.ts`  
**Función:** usa React Query (`useQuery`, `useMutation`).

**Para qué sirve:**
- Obtiene datos desde la API.
- Maneja caché, carga, errores e invalidación.
- Modelo recomendado de integración frontend-backend.

```
  import { useQuery, useMutation, useQueryClient } from "@tanstack/react-query";
import {
    obtenerPlanificacion,
    crearPlanificacion,
    actualizarPlanificacion,
    eliminarPlanificacion,
    listarPlanificacionesActuales,
    listarPlanificacionesTodo,
} from "../api/planificaciones.api";

import { planificacionesKeys } from "../api/planificaciones.keys";
import type { PlanificacionDto } from "../../../types/planificacion";

export function usePlanificacionesActualesList() {
    return useQuery({
        queryKey: planificacionesKeys.list(),
        queryFn: listarPlanificacionesActuales
    });
}

export function usePlanificacionesTodoList() {
    return useQuery({
        queryKey: planificacionesKeys.list(),
        queryFn: listarPlanificacionesTodo
    });
}

export function usePlanificacionDetail(id: number) {
    return useQuery({
        queryKey: planificacionesKeys.detail(id),
        queryFn: () => obtenerPlanificacion(id), 
        enabled: !!id
    });
}

export function useCrearPlanificacion() {
    const qc = useQueryClient();
    return useMutation<PlanificacionDto, Error, PlanificacionDto>({
        mutationFn: (dto) => crearPlanificacion(dto),
        onSuccess: () => {
        qc.invalidateQueries({ queryKey: planificacionesKeys.all });
        },
    });
}

export function useActualizarPlanificacion(id: number) {
    const qc = useQueryClient();
    return useMutation<PlanificacionDto, Error, PlanificacionDto>({
        mutationFn: (dto) => actualizarPlanificacion(id, dto),
        onSuccess: () => {
        qc.invalidateQueries({ queryKey: planificacionesKeys.all });
        qc.invalidateQueries({ queryKey: planificacionesKeys.detail(id) });
        },
    });
}

export function useEliminarPlanificacion() {
    const qc = useQueryClient();
    return useMutation<boolean, Error, number>({
        mutationFn: (id) => eliminarPlanificacion(id),
        onSuccess: () => {
          qc.invalidateQueries({ queryKey: planificacionesKeys.all });
        },
    });
}
```

---

#### `useNotas` (`useNotas.ts`)
**Ubicación:** `frontend/src/features/estudiantes/hooks/useNotas.ts`  
**Función:** obtiene reporte anual de notas de un estudiante.

**Características:**
- Solo consulta la API si existe `estudianteId`.
- Optimiza tráfico con `enabled: !!estudianteId`.

---

### 2.4. Servicios API

#### `EstudianteApi.ts`
**Ubicación:** `frontend/src/features/estudiantes/api/estudiantes.api.ts`  
**Función:**
- Realiza solicitudes HTTP con Axios (`apiClient`).
- Si `exito === false`, lanza error automáticamente.
- Devuelve únicamente los datos limpios al frontend.

---

#### `CompetenciaApi.ts`
**Ubicación:** `frontend/src/features/competencia/api/competencia.api.ts`  
**Estado:** retorna datos estáticos (`competenciasFake`).  
**Uso:** ideal para maquetación previa al backend real.

---
