namespace WebApplication1.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() => View();

    public string Square(int a, int h)
    {
        double s = a * h / 2f;
        return $"Площадь треугольника с основанием {a} и высотой {h} равна {s}";
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel
        { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}