## Patrón de software

El proyecto utiliza una **arquitectura en capas** bajo el patrón **Cliente-Servidor**, separando el **frontend** del **backend** para lograr una mayor escalabilidad, mantenibilidad y reutilización del código. El backend está estructurado en cinco capas: **API**, que conecta el Dominio con el Cliente; **CapaAuxiliar de Datos**, donde se ejecutan consultas especiales directamente en la base de datos con SQL; **Común**, que contiene los recursos compartidos entre capas; **Dominio**, que gestiona las entidades, servicios de negocio, utilidades, migraciones y configuración de la base de datos; e Intercambio, que define los objetos de transferencia de datos (DTOs).

Por su parte, el frontend, tiene una división en tres capas: **Servicio**, encargada de la comunicación con el backend; **Estado**, que administra los datos globales de la aplicación; y **Interfaz**, conformada por los componentes visuales y sus estilos. Esta arquitectura permite una clara separación de responsabilidades, facilita las pruebas unitarias y la evolución del sistema sin afectar el núcleo funcional del proyecto.

Por el lado del desarrollo, el backend está desarrollado en .NET con C#, utilizando el IDE Visual Studio como entorno principal de desarrollo; y el frontend está hecho en React con TypeScrip y se usará Visual Studio Code como IDE. 

---
