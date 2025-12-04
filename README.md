# INSTALL IN TERMINAL

```bash
dotnet new sln -n BibliotecaApi
dotnet new webapi -n BibliotecaApi
dotnet sln add BibliotecaApi/BibliotecaApi.csproj
```

# Estructura de carpetas que vas a crear dentro del proyecto BibliotecaApi

```bash
Controllers/
Models/           → Aquí van tus entidades (Book, Author, etc.)
DTOs/             → Objetos de transferencia (BookCreateDto, BookResponseDto)
Data/             → Tu DbContext y configuraciones EF
Repositories/     → Interfaces y clases repositorio
Services/         → Lógica de negocio (si la separas)
```

# Instala los paquetes NuGet que sí vas a usar

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools   # para migrations
dotnet add package Swashbuckle.AspNetCore               # Swagger
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

# Endpoints a implementar

```bash
GET     /api/books          → Lista paginada y filtrable (título o autor)
GET     /api/books/{id}     
POST    /api/books          → Crear libro (validar ISBN único)
PUT     /api/books/{id}     → Actualizar
DELETE  /api/books/{id}     → Borrado lógico (campo Activo = false)
```
