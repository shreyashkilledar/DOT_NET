using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webApp1.Models;

namespace webApp1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult contact()
    {
        return View();
    }
    public IActionResult quality()
    {
        return View();
    }
    public IActionResult Feedback()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
