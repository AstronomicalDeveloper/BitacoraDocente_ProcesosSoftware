## Requisitos de Usuario

Los siguientes requisitos expresan, en lenguaje natural, las funcionalidades que la profesora necesita que el sistema realice para optimizar la planificación de sus clases, el registro de desempeño y la gestión del aula.  
Cada requisito refleja una necesidad práctica observada durante la etapa de obtención de requisitos mediante medios como entrevista, cuestionario, analisis de dominio y reuniones creativas.

| ID | Requisito del usuario | Motivo / necesidad | Prioridad |
|----|------------------------|--------------------|------------|
| RU-01 | El sistema debe permitir **crear, modificar y eliminar** la planificación anual que agrupe todas las unidades de aprendizaje. | Mantener organizada la planificación general del año escolar. | Alta |
| RU-02 | El sistema debe permitir **registrar, modificar y eliminar** unidades de aprendizaje dentro de la planificación anual. | Facilitar la gestión y actualización de las unidades según el avance del año. | Alta |
| RU-03 | El sistema debe permitir **asociar a cada unidad sus respectivas sesiones de aprendizaje.** | Mantener la jerarquía pedagógica del currículo nacional. | Alta |
| RU-04 | El sistema debe permitir **registrar, modificar y eliminar sesiones** con su título, fecha y propósito. | Planificar clases de forma detallada y ordenada. | Alta |
| RU-05 | El sistema debe permitir **registrar, modificar y eliminar áreas curriculares**. | Mantener la coherencia y organización de las competencias y capacidades. | Alta |
| RU-06 | El sistema debe permitir **registrar, modificar y eliminar competencias y sus capacidades**, y asociarlas a cada área curricular. | Adaptar la planificación al currículo nacional y mantener la coherencia pedagógica. | Alta |
| RU-07 | El sistema debe permitir **registrar la asistencia** de los estudiantes por fecha y sesión. | Controlar la presencia y participación de los alumnos. | Alta |
| RU-08 | El sistema debe permitir **registrar y modificar por estudiante el cumplimiento de cada capacidad** (check) en una sesión. | Evaluar evidencias concretas del aprendizaje. | Alta |
| RU-09 | El sistema debe **calcular automáticamente** el porcentaje de capacidades cumplidas por estudiante y asignar el nivel correspondiente: **C (0–33%)**, **B (34–66%)** o **A (67–100%)**. | Estandarizar la evaluación y evitar errores manuales. | Alta |
| RU-10 | El sistema debe **recalcular automáticamente** el porcentaje y el nivel cuando se modifique un check o cambie el conjunto de capacidades de una sesión. | Mantener la consistencia de la evaluación. | Alta |
| RU-11 | El sistema debe permitir **generar reportes consolidados** de asistencia y desempeño por estudiante, sesión, unidad o planificación anual. | Facilitar la revisión pedagógica y la toma de decisiones. | Media |
| RU-12 | El sistema debe ofrecer una **interfaz simple e intuitiva**, accesible desde el equipo personal de la profesora. | Garantizar usabilidad y accesibilidad. | Alta |
| RU-13 | El sistema debe ofrecer un **módulo individual por estudiante** que consolide su información académica y de asistencia. | Consultar rápidamente el progreso de cada estudiante. | Alta |
| RU-14 | En el módulo de estudiante, se debe **visualizar el historial de desempeño** (por sesión y por unidad), mostrando porcentaje y nivel (C/B/A) derivados. | Seguimiento longitudinal del aprendizaje. | Alta |
| RU-15 | En el módulo de estudiante, se debe **visualizar el historial de asistencias** por fechas y sesiones. | Control y análisis de asistencia por alumno. | Alta |
| RU-16 | El sistema debe permitir **agregar observaciones** por estudiante (generales y/o asociadas a sesión/unidad). | Registrar notas cualitativas relevantes. | Media |
| RU-17 | El sistema debe **alertar** cuando un estudiante **supere el límite de faltas** definido para un periodo, unidad o planificación (configurable). | Prevención temprana y toma de acciones oportunas. | Alta |
| RU-18 | El sistema debe permitir **configurar el umbral de faltas** (por unidad/periodo/anual) y seleccionar si la advertencia es en pantalla y/o exportable en reporte. | Adaptar el control a la política docente. | Media |
| RU-19 | El sistema debe permitir crear **grupos de trabajo** de forma automática según criterios definidos por la profesora. | Ahorrar tiempo en la organización de actividades grupales. | Media |
| RU-20 | El sistema debe permitir **autenticación** de usuario (inicio/cierre de sesión) para acceder a las funcionalidades. | Proteger el acceso a la información académica. | Alta |
| RU-21 | El sistema debe permitir **gestionar grados y secciones** (p. ej., 1.º–6.º y A/B/C). | Organizar el aula según la estructura escolar real. | Alta |
