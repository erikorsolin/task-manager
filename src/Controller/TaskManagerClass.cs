using TaskManager.Models;

namespace TaskManager.Controller;

public class TaskManagerClass
{
    private List<TaskModel> tasks = new();
    private int nextId = 1;

    public void AddTask(string title, string description)
    {
        tasks.Add(new TaskModel(nextId++, title, description));
        Console.WriteLine("\nTarefa adicionada com sucesso!");
    }

    public void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nNenhuma tarefa cadastrada");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine($"\n{task}");
        }
    }

    public void FilterTasks(string column)
    {   
        if (string.IsNullOrEmpty(column))
        {
            Console.WriteLine("\nColuna inválida. Use: Backlog, Progress, Done ou Canceled.");
            return;
        }
        
        var normalized = char.ToUpper(column[0]) + column.Substring(1).ToLower();

        var validStatuses = Enum.GetNames(typeof(StatusEnum));
        if (!validStatuses.Contains(normalized))
        {
            Console.WriteLine("\nStatus inválido. Use: Backlog, Progress, Done ou Canceled.");
            return;
        }

        var parsedStatus = (StatusEnum)Enum.Parse(typeof(StatusEnum), normalized);
        var filteredTasks = tasks.Where(t => t.Status == parsedStatus).ToList();

        if (filteredTasks.Count == 0)
        {
            Console.WriteLine("\nNenhuma tarefa nessa coluna.");
            return;
        }

        foreach (var task in filteredTasks)
        {
            Console.WriteLine($"\n{task}");
        }
    }

    public void MoveTask(int id, string column)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.MoveTo(column);
            Console.WriteLine("\nTarefa movida com sucesso!");
        }
        else
        {
            Console.WriteLine("\nTarefa não encontrada.");
        }
    }

    public void RemoveTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine("\nTarefa removida!"); 
        }
        else
        {
            Console.WriteLine("\nTarefa não encontrada.");
        }
    }
}