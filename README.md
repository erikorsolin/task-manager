# Task Manager (⚠️ In progress)

A productivity-focused task manager built in C# that organizes tasks in a Kanban-style workflow. This project is evolving from a command-line application to a fully functional RESTful API, allowing integration with other systems and interfaces.

## Features

- **Command-line Interface**: Manage tasks directly from the terminal.
- **Kanban Workflow**: Organize tasks into categories like "To Do", "In Progress", and "Done".
- **Data Persistence**: Store tasks using SQLite and Entity Framework Core.
- **RESTful API**:
  - Endpoints for task management (CRUD operations).
  - Support for task filtering by status and priority.
  - Secure endpoints with JWT authentication (planned).
- **Containerization**: Dockerized for easy deployment and portability.

## Technologies Used

- **C#**: Primary programming language.
- **ASP.NET Core**: Framework for building the RESTful API.
- **Entity Framework Core**: ORM for database interaction.
- **SQLite**: Lightweight relational database.
- **Docker**: Containerization for deployment.
- **Swagger**: Documentation for API endpoints.
- **JWT**: Authentication for securing endpoints.

## Status

This project is under active development. The CLI application is complete, and the transition to a RESTful API is in progress.

## How to Run

### CLI Version
1. Clone the repository:
   ```bash
   git clone https://github.com/erikorsolin/task-manager.git
   ```
2. Navigate to the project directory:
   ```bash
   cd task-manager
   ```
3. Build and run the application:
   ```bash
   dotnet build
   dotnet run
   ```

### API Version (In Progress)
1. Clone the repository:
   ```bash
   git clone https://github.com/erikorsolin/task-manager.git
   ```
2. Navigate to the project directory:
   ```bash
   cd task-manager
   ```
3. Build and run the API:
   ```bash
   dotnet run --project TaskManager.Api
   ```
4. Access the API documentation (once Swagger is integrated):
   ```
   http://localhost:<port>/swagger
   ```

### Using Docker
1. Build the Docker image:
   ```bash
   docker build -t task-manager .
   ```
2. Run the container:
   ```bash
   docker run -p 8080:80 task-manager
   ```

## API Endpoints

- `GET /tasks`: Retrieve all tasks.
- `POST /tasks`: Create a new task.
- `GET /tasks/{id}`: Get details of a specific task.
- `PUT /tasks/{id}`: Update an existing task.
- `DELETE /tasks/{id}`: Delete a task.
- `GET /tasks?status={status}`: Filter tasks by status.
- `GET /tasks?priority={priority}`: Filter tasks by priority.

## Learning Objectives

This project is being developed as part of a learning journey to master backend development with C#. Key skills being acquired include:
- Developing a RESTful API using ASP.NET Core.
- Implementing secure authentication with JWT.
- Writing modular and scalable code.
- Using Docker for containerization and deployment.

## Contribution

This is a personal learning project and is not currently open for contributions. Feedback and suggestions are welcome. Please open an issue to provide input.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
