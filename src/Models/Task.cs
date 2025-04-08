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
        Status = TaskStatus.backlog;
    }

    public void MoveTo(int column)
    {
        switch (column)
            {
                case 1:
                    Status = TaskStatus.Backlog;
                    break;
                case 2:
                    Status = TaskStatus.Progress;
                    break;
                case 3:
                    Status = TaskStatus.Canceled;
                    break;
                case 4:
                    Status = TaskStatus.Done;
                    break;
            }
    }

    public override string ToString()
    {
        return $"{Id}: {Title} - {Status} \nDescrição: {Description}";
    }
}
