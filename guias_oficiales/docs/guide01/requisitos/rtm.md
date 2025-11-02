# Especificación de requisitos de software

## Requisitos funcionales
Los requisitos funcionales se expresan en lenguaje técnico a partir de los requisitos funcionales mandatorios que se han identificado en la categorización de requisitos de usuario.

| RF | Funcionalidad | RU que la justifican | Observaciones |
|---|---|---|---|
| RF-01 | CRUD **Planificación anual** | RU-01 | Raíz de jerarquía. |
| RF-02 | CRUD **Unidades** | RU-02 | — |
| RF-03 | **Asociar Sesiones** a Unidades | RU-03 | — |
| RF-04 | CRUD **Sesiones** | RU-04 | Incluye propósito y área. |
| RF-05 | CRUD **Competencias/Capacidades** + asociación | RU-05 | Vocabulario curricular. |
| RF-06 | **Asistencia** por sesión | RU-06 | Base para RF-08/alertas. |
| RF-07 | **Configurar umbrales** de faltas | RU-18 | — |
| RF-08 | **Detectar/Notificar** exceso de faltas | RU-17 | Incluye bandera en reportes. |
| RF-09 | **Registrar checks** de capacidades | RU-08 | Fuente de verdad (detalle). |
| RF-10 | **Calcular nivel** C/B/A | RU-09 | Nota derivada, no manual. |
| RF-11 | **Re-cálculo** ante cambios | RU-10 | Consistencia automática. |
| RF-12 | **Módulo estudiante** (historial + observaciones) | RU-13, RU-14, RU-15, RU-16 | Consolida desempeño y asistencia. |
| RF-13 | CRUD **Áreas curriculares** | RU-05 | Normaliza competencias/capacidades por área. |
  
## Requisitos no funcionales
### Portabilidad del software
| ID | Requisito | Criterio de aceptación |
|----|-----------|------------------------|
| RNF-01 | El sistema debe ejecutarse en **Windows 10 u 11 (64-bit)**. | La instalación y ejecución funciona en Windows 10 y 11 sin pasos adicionales (OK en ambos). |
| RNF-02 | El sistema debe instalarse con **procedimiento simple** (instalador o carpeta portable) sin requerir configuraciones complejas. | Instalación ≤ 5 minutos; no requiere cambios de registro ni privilegios elevados permanentes. |
| RNF-03 | La base de datos debe poder **migrarse de equipo** sin pérdida de datos. | Exportar/Importar (o copia de carpeta/backup) reproduce íntegramente la información en otro equipo Windows. |
| RNF-04 | El sistema debe poder ejecutarse **sin conexión a Internet**. | Todas las funciones mandatorias (CRUD, asistencia, cálculo, reportes PDF) operan offline. |

### Facilidad de mantenimiento:
| ID | Requisito | Criterio de aceptación |
|----|-----------|------------------------|
| RNF-05 | La solución debe estar **modularizada** (capas claramente separadas). | Estructura de carpetas y código refleja separación; cambios en una capa no rompen otra (revisión por pares). |
| RNF-06 | Debe existir **guía de despliegue y mantenimiento** (README técnico) con backup/restore y pasos de actualización. | Documento de 1–2 páginas incluido; cualquier miembro del equipo puede reinstalar/actualizar siguiendo la guía. |
| RNF-07 | El código debe seguir **estándares de estilo** y **comentarios** en componentes críticos (cálculo C/B/A, alertas). | Linting/pasa revisión; comentarios presentes en los módulos de cálculo y notificaciones. |
| RNF-08 | La base de datos debe contar con **script de creación** y **semillas mínimas** (áreas curriculares de ejemplo). | Migración reproduce el esquema desde cero y carga datos base. |
| RNF-09 | Las **configuraciones** (ruta de BD, carpeta de reportes) deben ser **externas** al código. | Archivo de configuración editable (ej. `.json`/`.ini`) permite cambiar rutas sin recompilar. |

### Usabilidad del software
| ID | Requisito | Criterio de aceptación |
|----|-----------|------------------------|
| RNF-10 | **Navegación simple**: acceso a las funciones principales en **≤ 3 clics** desde la pantalla inicial. | Pruebas con 3 casos (planificación, asistencia, registro de capacidades) cumplen ≤ 3 clics. |
| RNF-11 | **Consistencia de UI**: títulos, botones y filtros con **nomenclatura uniforme** y ayudas contextuales. | Revisión heurística: no hay términos distintos para misma acción; tooltips o textos de ayuda presentes. |
| RNF-12 | **Legibilidad**: tipografía mínima **12 pt**, contraste **WCAG AA** en textos y botones. | Inspección visual cumple tamaños y contraste; textos son legibles en proyector estándar. |
| RNF-13 | **Prevención de errores**: confirmación al **eliminar** y mensajes claros de validación. | Al eliminar, aparece confirmación; formularios muestran mensajes junto al campo inválido. |
| RNF-14 | **Accesibilidad básica**: navegación por **teclado** y orden de tabulación correcto en formularios. | Campos se recorren con TAB en orden lógico; botones activables con ENTER/ESPACIO. |

### Velocidad de procesamiento de datos
| ID | Requisito | Criterio de aceptación |
|----|-----------|------------------------|
| RNF-15 | **Tiempo de respuesta** de acciones comunes (abrir lista, guardar registro, marcar asistencia). | ≤ **3 s** en equipo objetivo con dataset típico (hasta 50 estudiantes, 12 unidades, 200 sesiones). |
| RNF-16 | **Generación de reportes** (PDF por estudiante, sesión, unidad o anual). | ≤ **5 s** para un reporte estándar; exportación correcta a archivo. |
| RNF-17 | **Re-cálculo** de nivel (C/B/A) y **alerta de faltas** tras cambios en checks o umbrales. | Reflejado en pantalla en ≤ **5 s** al refrescar (o automático si la vista se actualiza en vivo). |
| RNF-18 | **Arranque** de la aplicación. | Pantalla inicial lista en ≤ **5 s** en equipo objetivo. |

### Restricciones técnicas del software: 
| ID | Restricción | Criterio / Alcance |
|----|-------------|--------------------|
| RNF-19 | **Sistema operativo**: Windows 10/11, 64-bit. | Requisito mínimo. |
| RNF-20 | **Base de datos relacional local** (monousuario). | Sin servidor externo; archivo local/embebido es válido. |
| RNF-21 | **Exportación a PDF** para reportes. | Librería o componente compatible con Windows; sin dependencias en la nube. |
| RNF-22 | **Formato horario/localización**: América/Lima (24 h, dd/mm/aaaa). | Fechas y horas muestran y guardan este formato. |
| RNF-23 | **Alcance de datos** (límites de diseño): hasta **50 estudiantes**, **12 unidades**, **200 sesiones** por año. | La performance declarada (RNF-15..17) se garantiza dentro de estos límites. |
| RNF-24 | **Sin integraciones externas** (correo, autenticación institucional, APIs). | Fuera de alcance de la versión actual (ver RFNV). |
| RNF-25 | **Seguridad local básica**: archivos de datos en carpeta de usuario; sin elevación permanente. | El sistema guarda datos en rutas de usuario; no escribe en `Program Files`. |

## Elementos rechazados (para trazabilidad histórica)

| Propuesta | RU | Etiqueta RFNV | Decisión | Motivo |
|---|---|---|---|---|
| Reportes | RU-11 | RFNV-08 | Rechazado | No aporta valor al objetivo del sistema. |
| Grupos de trabajo automáticos | RU-19 | RFNV-01 | Rechazado | No aporta valor al objetivo del sistema. |
| Autenticación | RU-20 | RFNV-03 | Rechazado | Monousuario local; agrega complejidad. |
| Grados y secciones | RU-21 | RFNV-05/06 | Rechazado | Una sola aula; fuera de alcance. |
