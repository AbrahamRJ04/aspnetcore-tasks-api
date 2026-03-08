# ASP.NET Core Tasks API

RESTful API for managing tasks.

## Technologies
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Postman

## Features
- Create tasks
- Get tasks
- Update tasks
- Delete tasks

## API Endpoints

GET /api/tasks  
GET /api/tasks/{id}  
POST /api/tasks  
PUT /api/tasks/{id}  
DELETE /api/tasks/{id}

## NuGet Packages

Install-Package Microsoft.EntityFrameworkCore.SqlServer

Install-Package Microsoft.EntityFrameworkCore.Tools

Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection


## Migration from SQL Server

Add-Migration InitialCreate --> Fisrt step

Update-Database --> Second step

Remove-Migration --> Optional step


## Technologies

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Postman
- Dtos
