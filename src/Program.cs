using TaskManager.Controller;

using TaskManagerClass = TaskManager.Controller.TaskManager;

class Program
{
    static TaskManagerClass taskManager = new(); 

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n📌 GERENCIADOR DE TAREFAS 📌");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Concluir Tarefa");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTaskFlow();
                    break;
                case "2":
                    taskManager.ListTasks();
                    break;
                case "3":
                    CompleteTaskFlow();
                    break;
                case "4":
                    RemoveTaskFlow();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void AddTaskFlow()
    {
        Console.Write("Título: ");
        string title = Console.ReadLine();
        Console.Write("Descrição: ");
        string description = Console.ReadLine(); 
        taskManager.AddTask(title, description);
    }

    static void CompleteTaskFlow()
    {
        Console.Write("ID da tarefa a concluir: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            taskManager.CompleteTask(id);
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }

    static void RemoveTaskFlow()
    {
        Console.Write("ID da tarefa a remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            taskManager.RemoveTask(id);
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }
}
