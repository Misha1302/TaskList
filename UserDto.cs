namespace TaskList.Context;

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TaskList.Controllers;


public class UserDto
{
    public UserDto()
    {
        Name = string.Empty;
        Password = string.Empty;
        TaskValues = new List<TaskValue>();
    }

    public UserDto(string name, string password, List<TaskValue> taskValues)
    {
        Name = name;
        Password = password;
        TaskValues = taskValues;
    }

    [Key]
    public string Name { get; set; }

    public string Password { get; set; }
    public List<TaskValue> TaskValues { get; set; }
}