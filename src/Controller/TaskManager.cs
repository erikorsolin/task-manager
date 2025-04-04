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
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada");
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
            Console.WriteLine("Tarefa concluída!");
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
            Console.WriteLine("Tarefa removida!"); 
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
}
