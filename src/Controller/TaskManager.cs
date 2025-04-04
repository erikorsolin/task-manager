using TaskManager.Models

namespace TaskManager.Controller;

public class TaskManager
{
    private List<Task> tasks = new();
    private int nextId = 1;

    public void AddTask(string title, string description)
    {
        tasks.Add(new Task(nextId++), title, description);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada")
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task)
        }
    }

    public void CompleteTask()
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null);
        {
            task.Complete();
            Console.WriteLine("Tarefa Concluida!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    public void RemoveTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.Writeline("Tarefa removida!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.")
        }
    }
}