# Rick and Morty App - Blazor WebAssembly

Aplicación web hecha en **Blazor WebAssembly (.NET 10)** que consume la API pública de [Rick and Morty](https://rickandmortyapi.com/) y muestra los personajes en tarjetas, con paginación.

## Tecnologías
- .NET 10 / C#
- Blazor WebAssembly Standalone
- Bootstrap (incluido en la plantilla)
- API: https://rickandmortyapi.com/api/character

## Cómo ejecutarlo
1. Clonar el repositorio.
2. Abrir `RickAndMortyApp.csproj` en Visual Studio 2026 (o ejecutar `dotnet run` en la carpeta del proyecto).
3. Ejecutar con F5 y entrar a la opción **Personajes** del menú.

## Estructura principal
- `Models/` – clases que representan la respuesta JSON de la API (`RespuestaApi`, `Info`, `Personaje`, `Ubicacion`).
- `Pages/Personajes.razor` – página que llama a la API con `HttpClient` y muestra los personajes.
- `Pages/Personajes.razor.css` – estilos de la página.
