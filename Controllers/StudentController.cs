using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranXuanTruong.Net.Models;

namespace TranXuanTruong.Net.Controllers;

public class HomeControllers : Controller
{
    private readonly ILogger<HomeControllers> _logger;

    public HomeControllers(ILogger<HomeControllers> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string StudentName)
    {
        ViewBag.name = "Hello:" + " " + StudentName;
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
