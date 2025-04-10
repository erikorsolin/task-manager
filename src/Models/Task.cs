namespace TaskManager.Models;

public class TaskModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }

    public TaskModel(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = TaskStatus.Pendente;
    }

    public void Complete()
    {
        Status = TaskStatus.Concluida;
    }

    public override string ToString()
    {
        return $"{Id}: {Title} - {Status} \nDescrição: {Description}";
    }
}
