using System.Reflection.Metadata;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TranXuanTruong.Net.Models;

namespace TranXuanTruong.Net.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        List<Student> stdList = new List<Student>
        {
            new Student { StudentID = 11, StudentName = "Nguyen Van  A", StudentEmail = "Atr@gmail.com", StudentAge = 18},
            new Student { StudentID = 12, StudentName = "Nguyen Van B", StudentEmail = "Blu@gmail.com", StudentAge = 19},
            new Student { StudentID = 13, StudentName = "Nguyen Van C", StudentEmail = "MMM@gmail.com", StudentAge = 23},
            new Student { StudentID = 14, StudentName = "Nguyen Van D", StudentEmail = "ABC@gmail.com", StudentAge = 21},
            new Student { StudentID = 15, StudentName = "Nguyen Van E", StudentEmail = "TRuognta@gmail.com", StudentAge = 20}
        };
        ViewData["Student"] = stdList;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        // string message = std.StudentID + "-";
        // message += std.Student + "-";
        // message += std.StudentAge;
        // ViewBag.TT = message;
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(Student std)
    {
        std.StudentName = "Tin Học Kinh Tế";
        ViewBag.mess = std.StudentID;
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