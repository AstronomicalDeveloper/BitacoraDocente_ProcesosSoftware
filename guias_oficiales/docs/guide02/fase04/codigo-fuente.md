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

---

### 1.2. `SesionController.cs`
**Ubicación:** `backend/BitacoraDocente.API/Controllers/SesionController.cs`  
**Función:** Controla las sesiones de aprendizaje (clases diarias).

**Para qué sirve:**
- Registra qué se enseña en una fecha específica.
- Vincula una sesión con una Unidad Didáctica y Competencia.
- Define el propósito pedagógico y fecha de la clase.

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

#### `EstudianteServicio.cs` — Lógica de negocio
- Validación: evita duplicidad del número de documento.
- Algoritmo crítico: `CalcularNotaBimestre`
  - Calcula la nota según capacidades logradas vs evaluadas.
  - Maneja asistencia injustificada y su impacto en notas.
- Conversión numérica a cualitativa: transforma 0–100 en A, B, C.

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
