## 1. Seguimiento de la Planificación del Proyecto (Versión Final)
Para el presente proyecto de desarrollo del prototipo de software "Bitácora Docente", nuestro equipo ha ejecutado las actividades conforme a lo estipulado en el cronograma base, logrando cumplir con los hitos de entrega establecidos. La siguiente tabla detalla la ejecución real de las actividades, con fecha de cierre al 24 de noviembre de 2025, validando la sincronización entre el desarrollo del código fuente y los plazos académicos.
### Seguimiento de la Planificación del Proyecto (Ejecución Real)

| Fase | Actividad Principal | Inicio Real | Fin Real | Estado | Entregable Técnico (Evidencia) |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **I. Inicio** | Conformación del equipo y definición de alcance | 01/Sep/25 | 07/Sep/25 | **Completado** | Acta de constitución y Backlog inicial. |
| **II. Planificación** | Análisis de Requerimientos y Diseño de Arquitectura | 08/Sep/25 | 21/Sep/25 | **Completado** | Diagramas UML y definición de Stack (.NET + React). |
| **III. Ejecución** | **Iteración 1:** Maquetación Frontend y Estructura Base | 22/Sep/25 | 15/Oct/25 | **Completado** | Estructura de carpetas `src/features` y componentes UI. |
| | **Iteración 2:** Lógica de Negocio y APIs (Backend) | 10/Oct/25 | 10/Nov/25 | **Completado** | Controladores (`AsistenciaController`, `EstudianteController`). |
| | **Iteración 3:** Integración y Base de Datos (Sashimi) | 01/Nov/25 | 23/Nov/25 | **Completado** | Migración final `20251123012130` y conexión Axios. |
| **IV. Control** | Pruebas Unitarias y Corrección de Errores | 15/Nov/25 | 23/Nov/25 | **Completado** | Ajustes en DTOs (`EstudianteDto`) y validaciones. |
| **V. Cierre** | Despliegue de Prototipo y Documentación Final | 23/Nov/25 | 24/Nov/25 | **Completado** | Prototipo funcional y repositorio actualizado. |

2. Análisis Comparativo: Planificado vs. Real
Hasta la fecha, tras finalizar la ejecución del proyecto y realizar una evaluación comparativa entre la versión inicial de nuestra planificación y la ejecución real concluida el proximo 24 de noviembre, destacamos los siguientes aspectos de relevancia que validan nuestra gestión:

Eficacia de la Metodología Sashimi en la Integración Final: Aunque la planificación inicial sugería una secuencia lineal, la realidad de nuestra ejecución demostró la potencia del modelo "Sashimi". Logramos ajustar el esquema de datos (AppDbContext) en tiempo real según las necesidades que surgían desde el Frontend, logrando que la integración técnica y el cumplimiento del cronograma convergieran exitosamente en la fecha límite sin generar retrasos.

Mitigación de Dependencias mediante "Mocking": Un punto clave de nuestra estrategia fue el desacoplamiento temporal entre el desarrollo del Frontend y el Backend. Durante las fases intermedias (octubre-noviembre), el equipo de Frontend avanzó utilizando simulaciones de datos (archivos .fake.ts). Esta decisión garantizó que ningún miembro del equipo tuviera tiempos muertos.

Cumplimiento de Objetivos en Escenario de Alta Presión: A pesar de la complejidad técnica que implica una arquitectura limpia (Clean Architecture) con separación de capas (.API, .Dominio, .Intercambio), hemos logrado respetar los tiempos estipulados. La coincidencia entre la fecha de nuestra última confirmación de código importante (23/11) y el fin de la fase de ejecución demuestra un control preciso del alcance, validando que el prototipo entregado es funcional a nivel de código.
