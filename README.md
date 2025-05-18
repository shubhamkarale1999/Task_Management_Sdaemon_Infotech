# Task_Management_Sdaemon_Infotech

A simple task management API built using ASP.NET Core and Entity Framework.

## 🔧 Setup Instructions

1. Clone the repository

https://github.com/shubhamkarale1999/Task_Management_Sdaemon_Infotech.git

2. Open the solution in Visual Studio.

3. Make sure your `appsettings.json` is configured properly. Use SQL Server or InMemory DB.

4. Run the application. Swagger UI will be available at: https://localhost:7240/swagger/index.html

5. Open `index.html` in your browser to use the front-end. : https://localhost:7240/index.html

** API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/Tasks        | Get all tasks |
| GET    | /api/Tasks/{id}   | Get task by ID |
| POST   | /api/Tasks        | Add new task |
| PUT    | /api/Tasks/{id}   | Update task |
| DELETE | /api/Tasks/{id}   | Delete task |

** Sample JSON for Add/Update

json
{
"title": "Buy groceries",
"description": "Milk, Eggs, Bread",
"dueDate": "2025-05-20",
"isComplete": false
}

**Known Limitations (this things are improved in future)
No authentication/authorization.

No pagination/filtering yet.

Front-end is a static HTML + jQuery form.

Could improve error handling and UX.

**Future Improvements
Add user login

Add filtering, search

Improve UI (React, Angular, etc.)

