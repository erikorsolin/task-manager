# Task Manager

A productivity-focused task manager built in C# that simulates a simple Kanban system. This project is developed as part of a learning journey to improve backend development skills using C#. The application runs via the command line and includes features for task management, data persistence, and containerization.

## Features

- Command-line interface for task management.
- Task organization in a Kanban-style workflow (e.g., To Do, In Progress, Done).
- Data persistence using SQLite.
- Database management through Entity Framework Core (EF Core).
- Containerized with Docker for easy deployment and execution.
- Modular design following object-oriented programming principles.

## Technologies Used

- **C#**: Primary programming language.
- **SQLite**: Lightweight relational database for data persistence.
- **Entity Framework Core (EF Core)**: ORM for database interaction.
- **Docker**: Containerization for application packaging and deployment.

## Status

This project is currently under development. Features and functionality are being actively added and improved.

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/erikorsolin/task-manager.git
   ```
   
2. Change into the project directory:
   ```bash
   cd task-manager
   ```

3. Build the application:
   ```bash
   dotnet build
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Alternatively, you can use Docker to run the application:
   ```bash
   docker build -t task-manager .
   docker run task-manager
   ```

## Learning Objectives

- Gain proficiency in C# and its object-oriented programming features.
- Understand and implement database persistence with SQLite and Entity Framework Core.
- Learn the fundamentals of containerization using Docker.

## Future Features (Planned)

- Advanced task filtering and searching.
- User authentication and role management.
- API integration for remote task management.
- Enhanced error handling and validation.

## Contribution

This is a personal learning project and is not currently open for contributions. However, feedback and suggestions are welcome. Please open an issue if you'd like to provide input.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
