# Task Management API

A simple yet robust Task Management API built using the latest technologies in .NET 8, Entity Framework Core, and SQL Server 2022. It also includes a lightweight HTML + jQuery front-end for quick interaction.

## 🚀 Tech Stack
Backend: ASP.NET Core Web API (<TargetFramework>net8.0</TargetFramework>)

Database: Microsoft SQL Server 2022 Developer Edition (64-bit)
Version: 16.0.1000.6 (RTM)

ORM: Entity Framework Core

Front-End: HTML, Bootstrap 5, jQuery

API Testing: Swagger UI, Postman

## 🔧 Setup Instructions

1. Clone the repository:https://github.com/shubhamkarale1999/Task_Management_Sdaemon_Infotech.git

2. Open the solution in Visual Studio.

3. Make sure your `appsettings.json` is configured properly. Use SQL Server or InMemory DB.

4. Run the application. Swagger UI will be available at:https://localhost:7240/swagger

5. Open `index.html` in your browser to use the front-end.: https://localhost:7240/index.html

## API Endpoints

Method	Endpoint	Description
GET	/api/Tasks	Get all tasks
GET	/api/Tasks/{id}	Get task by ID
POST	/api/Tasks	Add new task
PUT	/api/Tasks/{id}	Update task
DELETE	/api/Tasks/{id}	Delete task

## Sample JSON for Add/Update
{
  "title": "Buy groceries",
  "description": "Milk, Eggs, Bread",
  "dueDate": "2025-05-20",
  "isComplete": false
}

## Known Limitations (To be improved in future)
- No authentication/authorization.
- No pagination/filtering yet.
- Front-end is a static HTML + jQuery form.
- Could improve error handling and UX.

## Future Improvements
- Add user login
- Add filtering, search
- Improve UI (React, Angular, etc.)


