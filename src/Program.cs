using TaskManager.Controller;

class Program
{
    static TaskManagerClass taskManager = new(); 

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nGERENCIADOR DE TAREFAS");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar todas as tarefas");
            Console.WriteLine("3. Filtrar tarefas por coluna");
            Console.WriteLine("4. Mover Tarefa");
            Console.WriteLine("5. Remover Tarefa");
            Console.WriteLine("6. Sair");
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
                    FilterTasksFlow();
                    break;
                case "4":
                    MoveTaskFlow();
                    break;
                case "5":
                    RemoveTaskFlow();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }
    }

    static void AddTaskFlow()
    {
        Console.Write("\nTítulo: ");
        string title = Console.ReadLine();
        Console.Write("Descrição: ");
        string description = Console.ReadLine(); 
        taskManager.AddTask(title, description);
    }

    static void FilterTasksFlow()
    {
        Console.Write("\nDigite a coluna (backlog, progress, canceled, done): ");
        string column = Console.ReadLine();
        taskManager.FilterTasks(column);
    }

    static void MoveTaskFlow()
    {
        Console.Write("\nDigite o ID e o destino: ");
        string[] input = Console.ReadLine().Split(' ');
        if (input.Length == 2 && int.TryParse(input[0], out int id))
        {
            string column = input[1].ToLower();
            taskManager.MoveTask(id, column);
        }
        else
        {
            Console.WriteLine("\nEntrada inválida.");
        }
    }

    static void RemoveTaskFlow()
    {
        Console.Write("\nID da tarefa a remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            taskManager.RemoveTask(id);
        }
        else
        {
            Console.WriteLine("\nID inválido.");
        }
    }
}