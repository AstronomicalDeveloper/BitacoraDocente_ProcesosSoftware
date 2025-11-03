## Patrón de software

El patrón de arquitectura utilizado en el proyecto es **Multicapa** (N-Tier), el cual organiza el software en distintos niveles con responsabilidades bien definidas. La **capa de presentación**, desarrollada en React con TypeScript, gestiona la interacción con el usuario mediante componentes visuales, manejo de estado y servicios que se comunican con el backend. La **capa API**, implementada en .NET Core con C#, expone servicios REST a través de controladores y endpoints que reciben las peticiones del cliente. La **capa lógica de negocio** contiene las entidades, servicios y validaciones que representan las reglas y procesos propios del sistema, además del mapeo entre entidades y DTOs. Finalmente, la **capa de acceso a datos** se encarga de la persistencia de la información, utilizando repositorios, Entity Framework Core y una base de datos MariaDB. Esta estructura mejora la mantenibilidad, escalabilidad y separación de responsabilidades, permitiendo que cada capa evolucione de manera independiente sin afectar al resto.

---

<img width="1920" height="1080" alt="patrón de" src="https://github.com/user-attachments/assets/85121326-5ab1-424b-b210-85b72e33ad5f" />
