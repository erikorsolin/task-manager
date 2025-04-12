namespace TaskManager.Models;

public class TaskModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public StatusEnum Status { get; set; }

    public TaskModel(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        Status = StatusEnum.Backlog;
    }

    public void MoveTo(string column)
    {
        switch (column)
            {
                case "backlog":
                    Status = StatusEnum.Backlog;
                    break;
                case "progress":
                    Status = StatusEnum.Progress;
                    break;
                case "canceled":
                    Status = StatusEnum.Canceled;
                    break;
                case "done":
                    Status = StatusEnum.Done;
                    break;
            }
    }
    public override string ToString()
    {
        return $"{Id}: {Title} - {Status} \nDescrição: {Description}";
    }
}