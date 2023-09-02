namespace TaskList.Controllers;

using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using TaskList.Context;

public class LoginController : Controller
{
    private readonly PostgreSqlContext _postgreSqlContext;

    public LoginController(PostgreSqlContext postgreSqlContext)
    {
        _postgreSqlContext = postgreSqlContext;
    }

    // https://localhost:44341/Login/register?name=name&password=Qwerty
    public string Register(string name, string password)
    {
        _postgreSqlContext.Users.Add(new UserDto(name, password, new List<TaskValue>()));

        _postgreSqlContext.SaveChanges();

        return HtmlEncoder.Default.Encode($"{name} - {password}");
    }

    // https://localhost:44341/Login/login?name=name&password=Qwerty
    public string Login(string name, string password)
    {
        var userDto = _postgreSqlContext.Users.FirstOrDefault(x => x.Name == name);

        if (userDto == null)
            return HtmlEncoder.Default.Encode($"No user with name {name}");

        if (userDto.Password != password)
            return HtmlEncoder.Default.Encode($"User with name {name} have other password");

        return HtmlEncoder.Default.Encode(userDto.ToString() ?? string.Empty);
    }
}