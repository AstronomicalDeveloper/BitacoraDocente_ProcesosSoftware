# Desglose del Trabajo (WBS)
Una estructura de desglose de trabajo (EDT), también conocida por WBS (Work Breakdown Structure) por sus siglas en inglés, es la descomposición de un proyecto que está organizado en varios niveles.
1. Análisis
   - Recopilar requisitos
      - Entrevista a la docente (problemas, flujos, datos mínimos).
   - Documentar casos de uso
      - 6–10 casos clave (ej.: registrar asistencia, calificaciones, reportes PDF, comunicación con apoderados, plan de clase).
      - Flujos alternos y reglas de negocio.
2. Diseño
   - Modelo de datos
      - Entidades base: Estudiante, Asistencia, Evaluación, Plan de Evaluación, Nota, Grupo, Nota Evaluación Grupo, Nota Evaluación, Asignatura, Evaluación Generada, Pregunta.
   - Interfaces de usuario:
      - Diseño de las vistas y navbar en Canva.
3. Implementación
   - Backend
      - Stack: FastAPI, MariaDB, DBaver, se usará el lenguaje de Pyhton.
      - Módulos: Autenticación/roles, alumnos/aulas, asistencia, evaluaciones, reportes (CSV/PDF), auditoría simple.
   - Frontend
      - Stack: React, Tailwind, HTML y CSS.
      - Páginas: Login, dashboard, alumnos, asistencia (marcado rápido), notas (tabla editable), reportes.
4. Pruebas
      - Unitarias: Pruebas de los componentes individuales del sistema (funciones, módulos).
      - Integración: Pruebas de integración del backend y frontend para garantizar la coherencia.
5. Entrega
      - Documentación final: Documento técnico que detalla la arquitectura del sistema, la base de          datos y el código.
      - Presentación y demostración del sistema (24 de noviembre).
  



# Tips para mayor claridad

## Propósito
Establecer el desglose del proyecto en actividades e identifica los hitos y entregables asociados con cada actividad considerando las especificaciones de requisitos del software identificados en el acápite d de la Fase 01 (Especificación de requisitos de software).

## Qué se espera: Ejemplo en tabla
| ID | Tarea | Entregable | Responsable |
|----|-------|------------|-------------|
| 1.1 | Recopilar requisitos | Documento de requisitos | Todos |
| 1.2 | Documentar casos de uso | Documento de casos de uso | Todos |
| 2.1 | Modelo de datos | Diagrama ER | Todos |
| 2.2 | Interfaces de usuario | Diapositivas en Canva | Landry |
| 3.1 | Backend | Código funcional | Gerardo |
| 3.2 | Frontend | Código funcional | Adrian |
| 4.1 | Pruebas unitarias | Reporte de pruebas unitarias | Paulo |
| 4.2 | Pruebas de integración | Reporte de pruebas de integración | Paulo |
| 5.1 | Documentación final | Documentación técnica | Todos |
| 5.2 | Presentación final | Presentación PowerPoint y video | Todos |
