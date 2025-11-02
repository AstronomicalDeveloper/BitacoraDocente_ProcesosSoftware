# Negociación y discusión de requisitos
Durante la fase de especificación de requisitos del *Sistema de Gestión de Planificación y Desempeño Docente*, se realizaron reuniones de revisión y validación con la profesora usuaria, así como sesiones internas del equipo de desarrollo.  
El objetivo fue **analizar la viabilidad y relevancia** de cada requisito identificado, **priorizar las funcionalidades esenciales** y **descartar aquellas que no aportaban valor** o excedían el alcance del proyecto académico.

## Tabla de negociación

| ID | Requisito / propuesta | Tipo de decisión | Resultado | Motivo |
|----|------------------------|------------------|------------|---------|
| RU-01 a RU-13 | Requisitos principales sobre planificación, unidades, sesiones, capacidades, asistencia y evaluación (C/B/A). | Aceptado | Se mantienen como base del sistema. | Son el núcleo funcional del software. |
| RU-14–RU-18 | Módulo individual de estudiante, observaciones y advertencia por faltas. | Aceptado con observaciones | Se incluirá el módulo de estudiante con observaciones y alertas configurables. | Aporta valor al seguimiento del progreso y control de asistencia. |
| RU-19 | Creación automática de grupos de trabajo. | Rechazado | Eliminados en la versión final. | La misma profesora pidió su eliminación, pues realmente no le aportaba valor real. |
| RU-20–RU-21 | Grados, secciones y autenticación. | Rechazado | Eliminados en la versión final. | No aportan valor en un sistema monousuario; exceden el alcance actual. |
| RFM-01–RFM-6 | Requisitos funcionales de mejora (gráficos, temas, exportación avanzada, etc.). | Aceptado parcialmente | Podrían desarrollarse en versiones futuras (fase 2). | Representan optimizaciones no críticas. |
| RFNV-01–RFNV-07 | Funcionalidades descartadas desde los primeros bocetos (autenticación, docentes, etc.). | Confirmado como rechazado | No serán implementadas. | No generan valor a la organización ni al propósito pedagógico. |

## Principales acuerdos
1. **El sistema será monousuario**, diseñado para una sola profesora, sin autenticación.  
2. **La nota o nivel de desempeño es derivada** del cumplimiento de capacidades (C/B/A) y se recalcula automáticamente.  
3. **Se mantiene el módulo de estudiante**, con historial, observaciones y alertas por faltas.  
4. **Los módulos de docentes, grados y secciones** fueron descartados por no ser relevantes al alcance actual.  
5. **Los requisitos de mejora** (gráficos, exportaciones, personalización) podrán considerarse en versiones posteriores.  
6. **Los requisitos no funcionales** se aplican de forma transversal a todo el sistema (rendimiento, interfaz, persistencia).

## Conclusión
El proceso de negociación permitió **definir una versión realista y funcional del sistema**, centrada en las necesidades actuales de la profesora usuaria. Las decisiones adoptadas aseguran un producto coherente con el alcance académico del proyecto y establecen una base sólida para futuras ampliaciones o adaptaciones institucionales.
