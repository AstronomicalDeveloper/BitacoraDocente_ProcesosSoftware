## Pruebas de caja negra
## Matriz de trazabilidad de las pruebas de caja negra
| RF     | ID CASO | Descripción breve del caso                    | Entrada(s)                                   | Resultado Esperado                 | Evidencia | Resultado |
|--------|---------|------------------------------------------------|-----------------------------------------------|------------------------------------|-----------|-----------|
| RF-01  | CU01    | Crear planificación anual                      | Ciencia y Ambiente; Año: 2024 |   Planificación creada  | <img width="1541" height="585" alt="image" src="https://github.com/user-attachments/assets/1f888390-5dde-48dc-9c94-abda2adae0e8" />          |  OK   |
| RF-01  | CU02    | Eliminar planificación anual                   | Ciencia y Ambiente; Año: 2024   | Planificación eliminada            |     <img width="1470" height="438" alt="image" src="https://github.com/user-attachments/assets/145b291f-11d5-43db-8ebe-26d6dee792e0" /> | OK        |
| RF-02  | CU03    | Registrar unidad de aprendizaje                | PRIMERA UNIDAD               | Unidad registrada     |    <img width="1162" height="664" alt="image" src="https://github.com/user-attachments/assets/7bcc8df6-ae69-4f63-83f9-278cafba471a" /> | OK        |
| RF-02  | CU04    | Eliminar unidad con sesiones asociadas        | Unidad: Matemática                            | Operación denegada                 |           | Fail      |
| RF-03  | CU05    | Asociar sesión a una unidad        | prueba - prueba 2              | Sesión asociada     |    <img width="1580" height="777" alt="image" src="https://github.com/user-attachments/assets/79dac907-c079-43c1-b6c4-f0275c5ce970" />  | OK        |
| RF-04  | CU06    | Registrar sesión           | Título: REGISTRO PRUEBA        | Sesión registrada                  |    <img width="1508" height="777" alt="image" src="https://github.com/user-attachments/assets/0a738069-896a-47e5-8e9f-cd10ded541ef" />       | OK        |
| RF-06  | CU07    | Registrar asistencia                           | Estudiante X / Sesión 01                     | Asistencia registrada              |           | OK        |
| RF-07  | CU08    | Configurar umbral de faltas                    | Umbral: 30%                                   | Umbral registrado                  |           | OK        |
| RF-08  | CU09    | Superar umbral de faltas                       | Inasistencias >= 30%                          | Alerta visible en pantalla         |           | OK        |
| RF-09  | CU10    | Registrar capacidad cumplida                   | Estudiante X / Capacidad 1                   | Check registrado                   |           | OK        |
| RF-10  | CU11    | Calcular nivel automáticamente                 | 40% de capacidades                            | Nivel asignado: B                  |           | OK        |
| RF-11  | CU12    | Recalcular nivel tras modificación             | 40% → 70%                                     | Nivel actualizado a A              |           | OK        |
| RF-12  | CU13    | Consultar módulo individual del estudiante     | Estudiante X                                  | Vista consolidada mostrada         |           | OK        |
| RF-13  | CU14    | Crear área curricular                          | Nombre: Comunicación                          | Área registrada                    |           | OK        |







