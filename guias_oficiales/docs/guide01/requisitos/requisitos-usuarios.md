# Requisitos de usuario
## Parte interesada principal
- ***Nombre:*** Lourdes Ccoicca Fernandez.

- ***Descripción:*** La profesora, de 35 años de edad, es licenciada en Educación Primaria por la Universidad Nacional Mayor de San Marcos. Actualmente se desempeña como docente nombrada en la Institución Educativa Miguel Grau, ubicada en el distrito de San Martín de Porres. Cuenta con doce años de experiencia en la enseñanza primaria, durante los cuales ha demostrado un alto compromiso con la planificación pedagógica y el seguimiento del progreso académico de sus estudiantes.

- ***Rol en el sistema:*** Única usuaria y administradora del software.

- ***Contexto:*** La profesora actualmente realiza la planificación y el registro de desempeño de forma manual en hojas o archivos de texto, lo que le demanda tiempo y dificulta mantener un control ordenado y visual de los avances de cada estudiante. Como parte de nuestro curso de Procesos de Software, el equipo tiene como proyecto final diseñar e implementar un sistema informático que tenga de propósito optimizar estas tareas, adaptado a las necesidades y expectativas de la docente.

## Intereses o necesidades principales

| Necesidad | Descripción |
|------------|-------------|
| **Planificación de sesiones de clase** | Registrar las sesiones con sus competencias, capacidades y desempeños esperados. |
| **Registro del desempeño estudiantil** | Evaluar y registrar el progreso individual de cada estudiante en cada sesión. |
| **Registro de asistencias** | Marcar de forma rápida la asistencia, tardanza, inasistencia justificada, inasistencia injustificada  de los estudiantes, con fechas automáticas y posibilidad de corrección. |
| **Cálculo automático de notas** | Que el sistema realice el promedio de calificaciones o desempeños de manera automática, evitando errores manuales y agilizando la evaluación. |
| **Creación automática de grupos de trabajo** | Permitir la formación de grupos de estudiantes de forma automática según criterios definidos (por ejemplo, desempeño, orden alfabético o número de integrantes). |
| **Generación de reportes** | Obtener reportes claros sobre el desempeño de los estudiantes y los avances por sesión o periodo. |
| **Accesibilidad y facilidad de uso** | Contar con una interfaz sencilla, amigable y accesible desde su computador personal. |

## Requisitos en lenguaje natural
Los siguientes requisitos expresan, en lenguaje natural, las funcionalidades que la profesora necesita que el sistema realice para optimizar la planificación de sus clases, el registro de desempeño y la gestión del aula.  
Cada requisito refleja una necesidad práctica observada durante la etapa de obtención de requisitos mediante medios como entrevista, cuestionario, analisis de dominio y reuniones creativas.

| ID | Requisito del usuario | Motivo / necesidad | Prioridad |
|----|------------------------|--------------------|------------|
| RU-01 | El sistema debe permitir **crear, modificar y eliminar** la planificación anual que agrupe todas las unidades de aprendizaje. | Mantener organizada la planificación general del año escolar. | Alta |
| RU-02 | El sistema debe permitir **registrar, modificar y eliminar** unidades de aprendizaje dentro de la planificación anual. | Facilitar la gestión y actualización de las unidades según el avance del año. | Alta |
| RU-03 | El sistema debe permitir **asociar a cada unidad sus respectivas sesiones de aprendizaje.** | Mantener la jerarquía pedagógica del currículo nacional. | Alta |
| RU-04 | El sistema debe permitir **registrar, modificar y eliminar sesiones** con su título, fecha, propósito y área curricular. | Planificar clases de forma detallada y ordenada. | Alta |
| RU-05 | El sistema debe permitir **registrar, modificar y eliminar competencias y sus capacidades**, asociándolas a cada sesión. | Adaptar la planificación al currículo nacional y mantener la coherencia pedagógica. | Alta |
| RU-06 | El sistema debe permitir **registrar la asistencia** de los estudiantes por fecha y sesión. | Controlar la presencia y participación de los alumnos. | Alta |
| RU-07 | El sistema debe permitir **marcar por estudiante el cumplimiento de cada capacidad** (check) en una sesión. | Evaluar evidencias concretas del aprendizaje. | Alta |
| RU-08 | El sistema debe **calcular automáticamente** el porcentaje de capacidades cumplidas por estudiante y asignar el nivel correspondiente: **C (0–33%)**, **B (34–66%)** o **A (67–100%)**. | Estandarizar la evaluación y evitar errores manuales. | Alta |
| RU-09 | El sistema debe **recalcular automáticamente** el porcentaje y el nivel cuando se modifique un check o cambie el conjunto de capacidades de una sesión. | Mantener la consistencia de la evaluación. | Alta |
| RU-10 | El sistema debe permitir **consultar, modificar o eliminar registros de desempeño** cuando sea necesario. | Corregir errores o actualizar evaluaciones. | Media |
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

# Anexo A: Técnicas de obtención de requisitos de software
Durante la fase de recopilación de información para el desarrollo del Sistema de Gestión de Planificación y Desempeño Docente, se aplicaron diversas técnicas de obtención de requisitos orientadas a comprender el contexto laboral de la profesora, identificar sus necesidades específicas y validar los procesos pedagógicos definidos en el currículo nacional.

A continuación, se describen las principales técnicas utilizadas:

## Entrevista estructurada
Se realizó una entrevista con la profesora. El propósito de esta técnica fue conocer sus responsabilidades académicas y administrativas, las limitaciones de las herramientas digitales que utiliza actualmente y sus expectativas respecto a un sistema que integre la gestión académica.

La entrevista permitió identificar que la docente planifica y registra la información de sus alumnos utilizando herramientas no integradas (principalmente Excel, Word y WhatsApp), lo que genera pérdida de tiempo y duplicidad de datos. Además, manifestó interés en contar con una aplicación que automatice el cálculo de notas, facilite el registro de asistencias y organice las sesiones de aprendizaje dentro de unidades.

> El registro de esta técnica se encuentra en el documento: [Entrevista estructurada sistema de gestión de alumnos .docx](https://github.com/user-attachments/files/22456992/Entrevista.Estructurada.Sistema.de.gestion.de.alumnos.docx)

## Cuestionario
Con el fin de complementar la entrevista y priorizar las necesidades más críticas, se aplicó un cuestionario breve que permitió identificar los principales problemas del proceso actual y evaluar las funcionalidades más deseadas por la usuaria.

El cuestionario confirmó que los principales inconvenientes son la desorganización de los datos, la necesidad de transcribir información entre herramientas y la falta de integración entre las tareas de planificación, asistencia y evaluación.

Asimismo, reflejó una disposición positiva hacia el uso de un sistema digital que sea intuitivo y que ahorre tiempo.

> El instrumento se encuentra en el archivo: [Mini Cuestionario de Requisitos.docx](https://github.com/user-attachments/files/22454872/Mini.Cuestionario.de.Requisitos.docx)

## Análisis de tareas y del dominio
Esta técnica consistió en estudiar las actividades que realiza la profesora en su entorno laboral y analizar el dominio educativo para comprender su terminología y estructura lógica.

Como parte de esta técnica, el equipo revisó el Currículo Nacional de Educación Básica Regular proporcionado por la docente, con el fin de entender la organización oficial del proceso pedagógico: planificación anual → unidades → sesiones de aprendizaje, así como los componentes que intervienen (competencias, capacidades, desempeños y estándares de aprendizaje).

El análisis permitió identificar las tareas que deben ser soportadas por el sistema:

- Elaborar la planificación anual y sus unidades.

- Registrar las sesiones de aprendizaje.

- Evaluar el desempeño y calcular las notas.

- Registrar la asistencia de los estudiantes.

- Generar reportes consolidados.

Este estudio fue esencial para definir la jerarquía funcional del sistema y garantizar que la herramienta utilice el mismo lenguaje pedagógico que la docente emplea en su práctica profesional.

## Reuniones creativas y aclaraciones finales
Durante la etapa de diseño conceptual, se realizaron pequeñas reuniones de trabajo con la profesora para resolver dudas específicas y validar ideas surgidas a partir de los primeros bocetos del sistema.
Estas sesiones informales funcionaron como espacios de co-creación, donde el equipo presentó propuestas (por ejemplo, la estructura jerárquica de planificación, unidades y sesiones) y recibió retroalimentación directa de la usuaria.

Gracias a estas reuniones, se ajustaron algunos términos, se confirmaron los criterios para la creación automática de grupos de trabajo y se definió que los reportes debían incluir tanto el rendimiento como la asistencia de cada estudiante.

## Hallazgos principales
- La profesora utiliza múltiples herramientas no integradas (Excel, Word, WhatsApp).

- Existe duplicidad de datos y necesidad de transcripción manual entre sistemas.

- Los cálculos de notas y asistencias se realizan manualmente.

- La información de cada estudiante está fragmentada.

- Se valora especialmente la automatización de tareas repetitivas.

- El sistema debe reflejar la estructura pedagógica oficial: planificación anual, unidades y sesiones.

- Las reuniones de co-creación mejoraron la precisión de los requisitos y la satisfacción de la usuaria.
