## 1. Seguimiento de la Planificación del Proyecto (Versión Final)
Para el presente proyecto de desarrollo del prototipo de software "Bitácora Docente", nuestro equipo ha ejecutado las actividades conforme a lo estipulado en el cronograma base, logrando cumplir con los hitos de entrega establecidos, hasta la implementacion de las APIs. Aqui el equipo empezó a tener atrasos al momento de ponerse de acuerdo como afrontar ciertos problemas que se presentaban, ocasionando un desface en los horarios de entrega de las ultimas 2 semanas del proyecto
### Seguimiento de la Planificación del Proyecto (Ejecución Real)

| Fase | Actividad Principal | Inicio Real | Fin Real | Estado | Entregable Técnico (Evidencia) |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **I. Inicio** | Conformación del equipo y definición de alcance | 01/Sep/25 | 07/Sep/25 | **Completado** | Acta de constitución y Backlog inicial. |
| **II. Planificación** | Análisis de Requerimientos y Diseño de Arquitectura | 08/Sep/25 | 21/Sep/25 | **Completado** | Diagramas UML y definición de Stack (.NET + React). |
| **III. Ejecución** | **Iteración 1:** Maquetación Frontend y Estructura Base | 22/Sep/25 | 15/Oct/25 | **Completado** | Estructura de carpetas `src/features` y componentes UI. |
| | **Iteración 2:** Lógica de Negocio y APIs (Backend) | 10/Oct/25 | 23/Nov/25 | **Completado** | Controladores (`AsistenciaController`, `EstudianteController`). |
| | **Iteración 3:** Integración y Base de Datos (Sashimi) | 01/Nov/25 | 23/Nov/25 | **Completado con retraso** | Migración final `20251123012130` y conexión Axios. |
| **IV. Control** | Pruebas Unitarias y Corrección de Errores | 15/Nov/25 | 23/Nov/25 | **Completado con retraso** | Ajustes en DTOs (`EstudianteDto`) y validaciones. |
| **V. Cierre** | Despliegue de Prototipo y Documentación Final | 23/Nov/25 | 24/Nov/25 | **Completado con retraso** | Prototipo funcional y repositorio actualizado. |

2. Análisis Comparativo: Planificado vs. Real
Hasta la fecha, tras finalizar la ejecución del proyecto y realizar una evaluación comparativa entre la versión inicial de nuestra planificación y la ejecución real concluida el proximo 24 de noviembre, destacamos los siguientes aspectos de relevancia que validan nuestra gestión:

Eficacia de la Metodología Sashimi en la Integración Final: Aunque la planificación inicial sugería una secuencia lineal, la realidad de nuestra ejecución demostró la potencia del modelo "Sashimi". A pesar de que se presentaron diversos problemas en la recta final, intentamos ajustar el esquema de datos (AppDbContext) en tiempo real según las necesidades que surgían desde el Frontend, aun así la integración técnica y el cumplimiento del cronograma no llegaron a converger exitosamente en la fecha límite.

Falta de mitigación de Dependencias mediante "Mocking": Una de las faltas para nuesra estrategia fue el desacoplamiento temporal entre el desarrollo del Frontend y el Backend. Durante las fases intermedias (octubre-noviembre), el equipo de Frontend hubiera avanzado de manera más rapida utilizando simulaciones de datos (archivos .fake.ts). Esta decision pudo haber logrado un gran impacto en los tiempos de entrega y la mitigacion de errores que se presentaron.

Poco cumplimiento de Objetivos en Escenario de Alta Presión: La complejidad técnica que implica una arquitectura limpia (Clean Architecture) con separación de capas (.API, .Dominio, .Intercambio), nos llevó a no respetar los tiempos estipulados. La coincidencia entre la fecha de nuestra última confirmación de código importante y el fin de la fase de ejecución demuestra una debilidad en el control preciso del alcance.
