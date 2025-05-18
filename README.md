**Task Management - Sdaemon Infotech**

A simple yet robust Task Management API built using the latest technologies in .NET 8, Entity Framework Core, and SQL Server 2022. It also includes a lightweight HTML + jQuery front-end for quick interaction.
** Tech Stack
- Backend: ASP.NET Core Web API (<TargetFramework>net8.0</TargetFramework>)
- Database: Microsoft SQL Server 2022 Developer Edition (64-bit)
  Version: 16.0.1000.6 (RTM)
- ORM: Entity Framework Core
- Front-End: HTML, Bootstrap 5, jQuery
- API Testing: Swagger UI, Postman
** Setup Instructions
1. Clone the Repository
   git clone https://github.com/shubhamkarale1999/Task_Management_Sdaemon_Infotech.git
   cd Task_Management_Sdaemon_Infotech
2. Open the solution in Visual Studio 2022 or newer.
3. Configure the database connection string in appsettings.json.
4. Run the Application. Swagger UI will be available at: https://localhost:7240/swagger/index.html
5. Open the front-end UI at: https://localhost:7240/index.html
** API Endpoints
Method	Endpoint	Description
GET	/api/Tasks	Get all tasks
GET	/api/Tasks/{id}	Get a task by ID
POST	/api/Tasks	Add a new task
PUT	/api/Tasks/{id}	Update existing task
DELETE	/api/Tasks/{id}	Delete a task
** Sample JSON for Add/Update
{
  "title": "Buy groceries",
  "description": "Milk, Eggs, Bread",
  "dueDate": "2025-05-20",
  "isComplete": false
}
** Project Structure Overview
- Models/TaskModel.cs: Defines the task entity structure.
- Data/AppDbContext.cs: EF Core DbContext managing the Tasks table.
- Controllers/TasksController.cs: API endpoints logic (GET, POST, PUT, DELETE).
- index.html: Simple front-end form with Bootstrap and jQuery inside wwwroot folder.
- Program.cs: Configures services, database, and Swagger.
**Known Limitations (to be improved later)
- No authentication or authorization
- No filtering, pagination, or search
- Static front-end without form validation or advanced UX
- No unit tests
** Future Improvements
- Add JWT-based authentication & role-based authorization
- Implement task filtering, sorting, and pagination
- Add dashboard with task analytics
- Improve front-end UI using React or Angular
- Add unit & integration tests for API
✅ Notes
- Built using the latest .NET 8.0
- SQL Server 2022 Developer Edition on Windows 10 Home (Build 19045)
- Swagger UI is integrated for easy API testing
- Supports real-time CRUD via simple jQuery-based front-end
