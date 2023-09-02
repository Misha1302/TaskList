namespace TaskList.Controllers;

using System.ComponentModel.DataAnnotations;

public class TaskValue
{
    [Key]
    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public bool IsPointed { get; set; }
    public bool IsFinished { get; set; }
    public bool IsArchived { get; set; }
}