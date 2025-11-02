# Desglose del Trabajo (WBS)
El Desglose de Trabajo (WBS) de este proyecto tiene como objetivo organizar de manera clara y detallada todas las actividades necesarias para desarrollar el sistema de seguimiento de estudiantes para la docente. Cada fase del proyecto —análisis, diseño, implementación, pruebas y entrega— se divide en tareas y sub-tareas con responsables y entregables definidos, lo que permite tener un control más preciso sobre el avance del proyecto. Esta estructura asegura que cada actividad sea realizada de manera ordenada, que los requerimientos se cumplan correctamente y que los resultados sean entregables concretos, facilitando la planificación, coordinación y seguimiento del proyecto hasta su finalización.   
1. Análisis
   - Recopilar requisitos
      - Entrevista a la docente (problemas, flujos, datos mínimos).
   - Documentar casos de uso
      - 6–10 casos clave (ej.: registrar asistencia, calificaciones, plan de clase, registrar informacion del alumno).
      - Flujos alternos y reglas de negocio.
2. Diseño
   - Modelo de datos
      - Entidades base: Estudiante, Asistencia, Evaluación, Plan de Evaluación, Nota, Grupo, Nota Evaluación Grupo, Nota Evaluación, Asignatura, Evaluación Generada, Pregunta.
   - Interfaces de usuario:
      - Diseño de las vistas y navbar en Canva.
3. Implementación
   - Backend
      - Stack: FastAPI, MariaDB, DBaver, se usará el lenguaje de C#.
      - Módulos: Autenticación/roles, alumnos/aulas, asistencia, evaluaciones, reportes (CSV/PDF), auditoría simple.
   - Frontend
      - Stack: React, Tailwind, HTML y CSS.
      - Páginas: Dashboard, módulo de alumnos, asistencia (marcado rápido), notas de sesión (tabla editable), reportes.
4. Pruebas
      - Unitarias: Pruebas de los componentes individuales del sistema (funciones, módulos).
      - Integración: Pruebas de integración del backend y frontend para garantizar la coherencia.
5. Entrega
      - Documentación final: Documento técnico que detalla la arquitectura del sistema, la base de datos y el código.
      - Presentación y demostración del sistema (24 de noviembre).
  



# Tips para mayor claridad

## Propósito
Esta estructura facilita la planificación, asignación de responsabilidades y control del avance del proyecto, asegurando que cada tarea tenga un entregable claro y medible. De esta manera, se garantiza que el desarrollo del sistema sea ordenado, cumpla con los requisitos establecidos y permita una entrega final de calidad.  
Establecer el desglose del proyecto en actividades e identifica los hitos y entregables asociados con cada actividad considerando las especificaciones de requisitos del software identificados en el acápite d de la Fase 01 (Especificación de requisitos de software).

## Qué se espera: Ejemplo en tabla

| ID   | Tarea                   | Entregable                                         | Responsable |
|------|------------------------|---------------------------------------------------|-------------|
| 1.1  | Recopilar requisitos    | Documento de requisitos con flujos, necesidades y objetivos del sistema | Todos |
| 1.2  | Documentar casos de uso | Documento de casos de uso con 6-10 casos clave, flujos alternos y reglas de negocio | Todos |
| 2.1  | Modelo de datos         | Diagrama ER completo con entidades y relaciones entre estudiantes, asignaturas, evaluaciones, notas y grupos | Todos |
| 2.2  | Interfaces de usuario   | Diapositivas y prototipos en Canva mostrando vistas, navegación y diseño de la plataforma | Landry |
| 3.1  | Backend                | Código funcional del backend incluyendo autenticación, gestión de alumnos, asistencia, evaluaciones y reportes | Gerardo |
| 3.2  | Frontend               | Código funcional del frontend con páginas de login, dashboard, alumnos, asistencia, notas y reportes | Adrian |
| 4.1  | Pruebas unitarias      | Reporte de pruebas unitarias verificando el correcto funcionamiento de funciones y módulos individuales | Paulo |
| 4.2  | Pruebas de integración | Reporte de pruebas de integración asegurando la comunicación y coherencia entre frontend y backend | Paulo |
| 5.1  | Documentación final     | Documento técnico completo detallando arquitectura, modelo de datos, funcionalidades y código | Todos |
| 5.2  | Presentación final      | Presentación PowerPoint y video demostrativo mostrando el sistema en funcionamiento | Todos |



