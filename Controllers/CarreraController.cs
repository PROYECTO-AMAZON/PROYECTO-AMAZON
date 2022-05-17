using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTO_AMAZON.Models;

namespace PROYECTO_AMAZON.Controllers;

public class CarreraController : Controller
{
    private readonly ILogger<CarreraController> _logger;

    public CarreraController(ILogger<CarreraController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}