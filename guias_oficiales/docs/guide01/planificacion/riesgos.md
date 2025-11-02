## Riesgos
La gestión de riesgos es un proceso iterativo clave para asegurar el éxito del proyecto. Su objetivo no es eliminar todos los riesgos, sino identificarlos, analizarlos y planificar una respuesta proactiva antes de que se conviertan en problemas.

A continuación, se presenta la matriz de riesgos identificados para el sistema de gestión académica, detallando su probabilidad de ocurrencia, el impacto potencial en el proyecto y las estrategias de mitigación que se implementarán para gestionarlos    


## Tabla de Riesgos

| ID | Riesgo | Probabilidad | Impacto | Mitigación |
|:--:|:--|:--:|:--:|:--|
| **R1** | Retraso en la recolección de requisitos por parte de la docente, debido a falta de tiempo o cambios en los criterios pedagógicos. | Media | Alta | Planificar reuniones anticipadas y periódicas con la docente, establecer entregables intermedios y documentar cada requerimiento validado para evitar ambigüedades. |
| **R2** | Pérdida de datos de los alumnos durante pruebas o mantenimiento del sistema, ya sea por errores humanos o fallas en el servidor. | Baja | Alta | Implementar copias de seguridad automáticas y redundantes, establecer un plan de recuperación ante desastres y restringir accesos críticos durante mantenimiento. |
| **R3** | Errores en el registro o visualización de calificaciones por fallas en la lógica del sistema o inconsistencias de datos. | Media | Alta | Realizar pruebas unitarias, de integración y de validación antes del despliegue. Usar entornos de prueba separados del entorno real para detectar errores oportunamente. |
| **R4** | Escasez de conocimientos técnicos del equipo de desarrollo en la integración con bases de datos MariaDB o gestión de conexiones. | Media | Medio | Brindar capacitación técnica al equipo, utilizar guías y documentación oficial de MariaDB |
| **R5** | Problemas de compatibilidad del sistema en navegadores diferentes, afectando la experiencia del usuario. | Baja | Medio | Pruebas de interfaz en Chrome, Edge y Firefox |
| **R6** | Cambios en los requerimientos del sistema por ajustes curriculares o administrativos durante el ciclo escolar. | Media | Alta | Aplicar control de versiones en los requisitos, mantener comunicación continua con la docente y usar metodologías ágiles que faciliten la adaptación. |
    
La gestión de riesgos se realizó siguiendo un enfoque proactivo, donde se identificaron, evaluaron y clasificaron los riesgos en las etapas iniciales del proyecto.
Cada riesgo fue categorizado según:

-**Probabilidad**: frecuencia o posibilidad de ocurrencia.
-**Impacto**: magnitud del efecto en caso de que ocurra.
-**Mitigación**: estrategias para prevenir o reducir consecuencias.

Se utilizó una escala cualitativa (Alta, Media, Baja) para evaluar estos parámetros, y se definieron acciones preventivas y planes de contingencia.

