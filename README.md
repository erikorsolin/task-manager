# Task Manager 

A simple task manager built in C# that organizes tasks in a Kanban-style workflow. This project is evolving from a command-line application.

## Features

- **Command-line Interface**: Manage tasks directly from the terminal.
- **Kanban Workflow**: Organize tasks into categories like "Backlog", "Progress", "Canceled" and "Done".

## Technologies Used

- **C#**: Primary programming language.
- **Docker**: Containerization for deployment.

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

### Using Docker
1. Build the Docker image:
   ```bash
   docker build -t task-manager .
   ```
2. Run the container:
   ```bash
   docker run -it task-manager
   ```

## Contribution

This is a personal learning project and is not currently open for contributions. Feedback and suggestions are welcome. Please open an issue to provide input.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
