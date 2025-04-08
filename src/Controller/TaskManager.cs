using TaskManager.Models;
using TaskModel = TaskManager.Models.Task;

namespace TaskManager.Controller;

public class TaskManager
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

    public void CompleteTask(int id) 
    {
        var task = tasks.FirstOrDefault(t => t.Id == id); 
        if (task != null)
        {
            task.Complete();
            Console.WriteLine("\nTarefa concluída!");
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