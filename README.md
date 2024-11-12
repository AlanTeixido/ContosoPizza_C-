# ContosoPizzaSolution 🍕

Este es un proyecto de API REST en .NET que permite gestionar una lista de pizzas. La API proporciona operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para la entidad `Pizza` y está diseñada con una arquitectura de capas que facilita la extensibilidad y el mantenimiento. Utiliza Entity Framework Core para las operaciones de base de datos y Swagger para la documentación de la API.

## Tabla de Contenidos

- [Características](#características)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Requisitos Previos](#requisitos-previos)
- [Configuración del Proyecto](#configuración-del-proyecto)
- [Ejecutar Migraciones](#ejecutar-migraciones)
- [Uso de la API](#uso-de-la-api)
- [Documentación de la API](#documentación-de-la-api)
- [Errores Comunes y Soluciones](#errores-comunes-y-soluciones)
- [Pruebas](#pruebas)

---

## Características

- API RESTful para gestionar pizzas en una base de datos.
- CRUD completo para la entidad `Pizza`.
- Arquitectura de capas (`Application`, `Contracts`, `Domain`, `Infrastructure`, `Repositories`).
- Uso de Entity Framework Core para el acceso a datos.
- Documentación de la API generada con Swagger.
- Configuración para habilitar CORS.

## Estructura del Proyecto

La solución `ContosoPizzaSolution` está dividida en varios proyectos para mantener una arquitectura limpia y modular:

- **ContosoPizza.Application**: Contiene la lógica de aplicación.
- **ContosoPizza.Contracts**: Define los modelos de `Request` y `Response` para la API.
- **ContosoPizza.Domain**: Contiene las entidades principales (por ejemplo, `Pizza`).
- **ContosoPizza.Infrastructure**: Configuración de Entity Framework Core y conexión a la base de datos.
- **ContosoPizza.Repositories**: Implementación de repositorios, incluyendo el repositorio genérico y `PizzaRepository`.
- **ContosoPizzaSolution**: Capa de presentación que expone los controladores y la configuración general de la API.

## Requisitos Previos

Asegúrate de tener instalados los siguientes programas:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) o cualquier otra base de datos compatible con Entity Framework Core.
- [Git](https://git-scm.com/downloads) (opcional para clonar el repositorio).

## Uso de la API

La API proporciona los siguientes endpoints:

- `GET /api/pizza` - Obtiene todas las pizzas.
- `GET /api/pizza/{id}` - Obtiene una pizza específica por su ID.
- `POST /api/pizza` - Crea una nueva pizza.
- `PUT /api/pizza/{id}` - Actualiza una pizza existente.
- `DELETE /api/pizza/{id}` - Elimina una pizza por su ID.

## Documentación de la API
Swagger está habilitado para visualizar la documentación de la API. Después de iniciar la aplicación, navega a: http://localhost:5000/swagger

## Errores Comunes y Soluciones

- **Error de Resolución de Servicios**: Asegúrate de que los servicios, como los repositorios, están registrados en `Program.cs`.
- **Error de NULL en Propiedades**: Usa constructores para inicializar propiedades obligatorias o marca propiedades como `required` en C# 11.
- **Error de CORS en Swagger**: Configura CORS en `Program.cs` para permitir peticiones desde el entorno de desarrollo.
- **Error 500 en el Controlador**: Verifica que el repositorio esté correctamente inyectado y configurado en `Program.cs`.

## Pruebas

### Pruebas de CRUD con Swagger:

1. `GET /api/pizza`: Devuelve la lista de pizzas.
2. `POST /api/pizza`: Crea una pizza con datos válidos.
3. `GET /api/pizza/{id}`: Devuelve los datos de una pizza específica.
4. `PUT /api/pizza/{id}`: Actualiza una pizza existente.
5. `DELETE /api/pizza/{id}`: Elimina una pizza.



