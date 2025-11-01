## Patrón de software

Patrón de diseño del software (IDE de desarrollo) / Patrón de la arquitectura del software según corresponda con la naturaleza del proyecto de prototipo de software: Presente un esquema gráfico de su propuesta y explique con un párrafo de 10 líneas aproximadamente su patrón tomando como base la sesión correspondiente a la Semana 06: Patrones de Diseño de Software.

El sistema de seguimiento académico se desarrolla en C# aplicando una arquitectura de tres capas, lo que permite una estructura clara y ordenada.
En la capa de presentación se encuentran los formularios e interfaces que usa la profesora para registrar notas, asistencia y revisar el progreso de los alumnos. Esta capa se enfoca únicamente en la interacción con el usuario y no maneja directamente los datos.
La capa de negocio contiene la lógica del sistema, encargándose de procesar la información, calcular promedios y validar que los datos ingresados sean correctos. Actúa como intermediaria entre la interfaz y la base de datos, garantizando que las reglas del sistema se cumplan.
La capa de datos se ocupa de conectarse con la base de datos, ejecutar consultas y guardar la información de los alumnos, cursos y notas. Esta conexión se realiza mediante una librería que permite comunicar el programa con MariaDB.
Cada capa cumple un rol específico, evitando que los cambios en una afecten a las demás. Gracias a esta separación, el código es más fácil de mantener, probar y escalar en el futuro.
Además, la arquitectura facilita el trabajo en equipo y el control de versiones con herramientas como Git y GitHub, asegurando orden y colaboración durante el desarrollo del proyecto.
