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
        Status = TaskStatus.Backlog;
    }

    public void MoveTo(string column)
    {
        switch (column)
            {
                case "backlog":
                    Status = TaskStatus.Backlog;
                    break;
                case "progress":
                    Status = TaskStatus.Progress;
                    break;
                case "canceled":
                    Status = TaskStatus.Canceled;
                    break;
                case "done":
                    Status = TaskStatus.Done;
                    break;
            }
    }

    public override string ToString()
    {
        return $"{Id}: {Title} - {Status} \nDescrição: {Description}";
    }
}