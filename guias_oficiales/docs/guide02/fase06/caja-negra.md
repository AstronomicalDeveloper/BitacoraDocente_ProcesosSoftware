## Pruebas de caja negra
## Matriz de trazabilidad de las pruebas de caja negra
| RF     | ID CASO | Descripción breve del caso                    | Entrada(s)                                   | Resultado Esperado                 | Evidencia | Resultado |
|--------|---------|------------------------------------------------|-----------------------------------------------|------------------------------------|-----------|-----------|
| RF-01  | CU01    | Crear planificación anual                      | Ciencia y Ambiente; Año: 2024 |   Planificación creada  |           |  OK   |
| RF-01  | CU02    | Eliminar planificación anual                   | Ciencia y Ambiente; Año: 2024   | Planificación eliminada            |      | OK        |
| RF-02  | CU03    | Registrar unidad de aprendizaje                | PRIMERA UNIDAD               | Unidad registrada     |     | OK        |
| RF-02  | CU04    | Eliminar unidad con sesiones asociadas        | Unidad: Matemática                            | Operación denegada                 |           | Ok      |
| RF-03  | CU05    | Asociar sesión a una unidad        | prueba - prueba 2              | Sesión asociada     |      | OK        |
| RF-04  | CU06    | Registrar sesión           | Título: REGISTRO PRUEBA        | Sesión registrada                  |           | OK        |
| RF-06  | CU07    | Registrar asistencia                           | Estudiante X / Sesión 01                     | Asistencia registrada              |           | OK        |
| RF-07  | CU08    | Configurar umbral de faltas                    | Umbral: 30%                                   | Umbral registrado                  |           | OK        |
| RF-08  | CU09    | Superar umbral de faltas                       | Inasistencias >= 30%                          | Alerta visible en pantalla         |           | OK        |
| RF-09  | CU10    | Registrar capacidad cumplida                   | Estudiante X / Capacidad 1                   | Check registrado                   |           | OK        |
| RF-10  | CU11    | Calcular nivel automáticamente                 | 40% de capacidades                            | Nivel asignado: B                  |           | OK        |
| RF-11  | CU12    | Recalcular nivel tras modificación             | 40% → 70%                                     | Nivel actualizado a A              |           | OK        |
| RF-12  | CU13    | Consultar módulo individual del estudiante     | Estudiante Higares Martinez, Alejandro       | Vista consolidada mostrada         |        | OK        |
| RF-13  | CU14    | Crear área curricular   | Nombre: CREAR AREA PRUEBA                          | Área registrada                    |        | OK        |


<img width="1541" height="585" alt="image" src="https://github.com/user-attachments/assets/1f888390-5dde-48dc-9c94-abda2adae0e8" />

<img width="1470" height="438" alt="image" src="https://github.com/user-attachments/assets/145b291f-11d5-43db-8ebe-26d6dee792e0" />

<img width="1162" height="664" alt="image" src="https://github.com/user-attachments/assets/7bcc8df6-ae69-4f63-83f9-278cafba471a" />

<img width="1580" height="777" alt="image" src="https://github.com/user-attachments/assets/79dac907-c079-43c1-b6c4-f0275c5ce970" />

<img width="1508" height="777" alt="image" src="https://github.com/user-attachments/assets/0a738069-896a-47e5-8e9f-cd10ded541ef" />

<img width="1640" height="869" alt="image" src="https://github.com/user-attachments/assets/2b27955c-adf5-458e-9666-15ef79d29b93" />

<img width="1638" height="854" alt="image" src="https://github.com/user-attachments/assets/4cedd7f1-7ba1-43f0-adc5-2757233b3abc" />




