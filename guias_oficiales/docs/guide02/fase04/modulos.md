## Estructura General del Prototipo

El software está organizado en **Módulos Funcionales (Features)** accesibles mediante una barra de navegación (`Sidebar.tsx`).  
La arquitectura separa claramente la **gestión administrativa (configuración curricular)** del **seguimiento diario (estudiantes y clases)**.

---

# 1. Módulo de Estudiantes (Gestión y Seguimiento)

Este es el módulo principal para el seguimiento individualizado de los alumnos.

**Opciones de menú:** Estudiantes (o Alumnos)  
**Rutas asociadas:**  
- `/estudiantes`
- `/estudiantes/crear`
- `/estudiantes/:id`

### Rutinas Principales

| Rutina / Pantalla     | Funcionalidad | Componente Clave |
|-----------------------|---------------|------------------|
| Listado General       | Visualiza la lista de estudiantes con búsqueda y filtros. | `EstudiantesListPage.tsx` |
| Alta de Estudiante    | Registra nuevos alumnos con información personal y académica. | `EstudianteCreatePage.tsx` |
| Expediente Digital    | Vista detallada con información completa del estudiante. | `EstudiantePanelPage.tsx` |

### Submódulos del Expediente (Panel del Estudiante)

Dentro del perfil del estudiante se accede a secciones específicas:

- **Datos Generales:** edición de información básica  
  `DatosGenerales.tsx`
- **Control de Asistencia:** historial de faltas y tardanzas  
  `AsistenciaSection.tsx`
- **Registro de Notas:** visualización y carga de calificaciones  
  `NotasSection.tsx`
- **Hoja de Incidencias:** registro de observaciones académicas o conductuales  
  `ObservacionesSection.tsx`

---

# 2. Módulo de Planificación Académica

Permite organizar el trabajo de aula desde la unidad didáctica hasta la sesión diaria.

**Opciones de menú:** Planificación / Unidades  
**Rutas asociadas:**  
- `/planificacion`
- `/sesiones`
- `/sesiones/crear`

### Rutinas Principales

| Rutina / Pantalla         | Funcionalidad | Componente Clave |
|---------------------------|---------------|------------------|
| Gestión de Unidades       | Lista unidades didácticas planificadas para el ciclo escolar. | `UnidadesDidacticasList...` (inferido) |
| Programación de Sesiones  | Muestra sesiones de clase con fechas y contenidos programados. | `SesionesPage.tsx` |
| Diseño de Sesión          | Formulario para crear una sesión definiendo objetivos y actividades. | `CrearSesionPage.tsx` |
| Asignación Curricular     | Vincula competencias específicas a una sesión. | `getCompetenciasPorCurso.ts` |

---

# 3. Módulo de Configuración Curricular (Catálogos)

Módulo de soporte para gestionar los estándares de aprendizaje evaluables.

**Opciones de menú:** Configuración o Currículo

### Rutinas Principales

| Rutina / Pantalla | Funcionalidad | Componente Clave |
|-------------------|---------------|------------------|
| Competencias      | ABM (Alta, Baja, Modificación) de competencias educativas oficiales. | `CompetenciaListPage.tsx` |
| Capacidades       | Gestión de capacidades específicas dentro de cada competencia. | `CapacidadListPage.tsx` |

---
