# Categorización lógica de requisitos (Organización de los requisitos de usuario)
Los requisitos obtenidos durante la fase de especificación fueron analizados y clasificados en dos grandes categorías: **funcionales** y **no funcionales**.  
Esta categorización permite distinguir las funciones que el sistema debe realizar de las características de calidad que debe cumplir para garantizar su correcto desempeño.

## Requisitos funcionales mandatorios
Representa los requisitos que debe soportar el software es decir que el software sin ellos no funciona. Describen las acciones que el sistema debe realizar para satisfacer las necesidades de la profesora usuaria.

| ID | Descripción | Justificación |
|----|--------------|----------------|
| RF-01 | Crear, modificar y eliminar la **planificación anual** que agrupe las unidades de aprendizaje. | Organizar la estructura general del año escolar. |
| RF-02 | Registrar, modificar y eliminar **unidades de aprendizaje** dentro de la planificación anual. | Permitir flexibilidad en la gestión pedagógica. |
| RF-03 | Asociar **sesiones de aprendizaje** a las unidades correspondientes. | Mantener la jerarquía del currículo nacional. |
| RF-04 | Registrar, modificar y eliminar **sesiones** con su título, fecha y propósito. | Facilitar la planificación detallada de clases. |
| RF-05 | Registrar, modificar y eliminar **competencias y capacidades**, y asociarlas a cada área curricular. | Alinear la planificación con el currículo educativo. |
| RF-06 | Registrar **la asistencia** de los estudiantes por fecha y sesión. | Controlar la presencia de los alumnos. |
| RF-07 | **Configurar umbrales de faltas** por periodo/unidad/anual. | Ajuste a la política pedagógica. |
| RF-08 | **Detectar y notificar** cuando un estudiante **supere el umbral** de faltas (alerta visual en el módulo y bandera en reportes). | Intervención temprana y trazabilidad. |
| RF-09 | Registrar el **cumplimiento de capacidades** por estudiante mediante un sistema de checks. | Llevar control individual del aprendizaje. |
| RF-10 | **Calcular automáticamente** el porcentaje de capacidades cumplidas y asignar el nivel: **C (0–33%)**, **B (34–66%)**, **A (67–100%)**. | Automatizar la evaluación y reducir errores. |
| RF-11 | **Recalcular automáticamente** el porcentaje y nivel al modificar un check o el conjunto de capacidades de una sesión. | Asegurar consistencia en la evaluación. |
| RF-12 | Generar **reportes consolidados** de desempeño y asistencia por estudiante, sesión, unidad o planificación anual. | Proveer información resumida para seguimiento académico. |
| RF-13 | Proveer un **módulo individual de estudiante** que consolide desempeño (porcentaje y nivel C/B/A) y asistencia por fechas/sesiones/unidades. | Vista 360° para seguimiento por alumno. |
| RF-014 | Crear, modificar y eliminar las **áreas curriculares** que contenga a las competencias y capacidades. | Ayuda a la organización del proyecto. |

## Requisitos funcionales de mejora
Los siguientes requisitos representan **mejoras o extensiones** de las funcionalidades mandatorias del sistema.  
No son indispensables para el funcionamiento inicial, pero aportan **eficiencia, personalización y valor agregado** al uso docente.

| ID | Descripción | Justificación |
|----|--------------|----------------|
| RFM-01 | Permitir **generar gráficos estadísticos** de asistencia y desempeño (barras, líneas, pastel) por estudiante. | Facilita la interpretación visual del progreso y la toma de decisiones. |
| RFM-02 | Incorporar un **buscador inteligente** que permita filtrar rápidamente estudiantes, unidades o sesiones. | Acelera la navegación y mejora la productividad. |
| RFM-03 | Permitir **exportar reportes a formatos adicionales** (Excel, CSV) además de PDF. | Facilita la integración con otras herramientas y la manipulación de datos. |
| RFM-04 | Integrar una función de **respaldo automático** de la base de datos (backup) cada cierto tiempo. | Evita pérdida de información ante fallas del sistema. |
| RFM-05 | Incluir un módulo de **estadísticas globales** que muestre promedios de desempeño y asistencia por curso, unidad o periodo. | Proporciona una visión general del rendimiento del grupo. |
| RFM-6 | Permitir **copiar o duplicar planificaciones anteriores** para un nuevo año académico. | Ahorra tiempo en la configuración inicial del siguiente periodo lectivo. |

## Requisitos funcionales que no generan valor a la organización
Estos requisitos fueron considerados durante la etapa inicial de levantamiento, pero se determinó que **no contribuyen al objetivo central del software** ni ofrecen beneficios significativos a la usuaria o a la organización educativa.  
Por lo tanto, **no serán implementados en la versión actual** del sistema.

| ID | Descripción | Motivo de exclusión |
|----|--------------|--------------------|
| RFNV-01 | Crear **grupos de trabajo automáticos** entre estudiantes. | No aporta valor al proceso de planificación ni evaluación individual; la usuaria es la única docente y gestiona la clase directamente. Además, ella misma indicó su exclusión. |
| RFNV-02 | Incorporar **módulos de calificaciones numéricas** independientes. | La evaluación se realiza mediante cumplimiento de capacidades y niveles (C/B/A); añadir notas numéricas duplicaría la información. |
| RFNV-03 | Módulo de **autenticación de usuarios** (inicio y cierre de sesión). | El sistema será utilizado solo por una profesora en un entorno local, sin acceso externo; la autenticación no es necesaria y agrega complejidad innecesaria. |
| RFNV-04 | Módulo de **gestión de docentes** (registro y control de múltiples usuarios). | El sistema está diseñado para una única docente; la gestión de varios docentes no aporta valor actual. |
| RFNV-05 | Módulo de **grados y secciones**. | El sistema está enfocado en una sola aula; incluir estructura por grados y secciones no es relevante ni necesario. |
| RFNV-06 | Función de **asignar estudiantes a grados y secciones**. | La profesora trabaja con un único grupo estable durante el año escolar. |
| RFNV-07 | Módulo de **autorización por roles** (administrador, docente, asistente). | No existen otros usuarios; los roles no son aplicables al alcance del sistema. |
