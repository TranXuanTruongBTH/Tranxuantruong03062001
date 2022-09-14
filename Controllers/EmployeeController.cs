using Microsoft.AspNetCore.Mvc;
using TranXuanTruong.Net.Models;
namespace TranXuanTruong.Net.Controllers
{
  public class EmployeeController : Controller 
  {
    public ActionResult Index()
    {
        List<Employee> StdList= new List<Employee>
        { 
            new Employee { EmployeeID = 121, EmployeeName = "Nguyen Van A", EmployeeAge = 16 },
            new Employee { EmployeeID = 122, EmployeeName = "Nguyen Van B",  EmployeeAge = 17 },
            new Employee { EmployeeID = 132, EmployeeName = "Nguyen Van C", EmployeeAge = 18 },
            new Employee { EmployeeID = 134, EmployeeName = "Nguyen Van D", EmployeeAge = 19 },
            new Employee { EmployeeID = 155, EmployeeName = "Nguyen Van E", EmployeeAge = 20 }
        };
         ViewData["Employee"] = StdList;
        return View();
    }

    [HttpPost]
    public IActionResult Index(Employee std)
    {
        int ID = std.EmployeeID;
        String Name = std.EmployeeName;
        int Phone = std.EmployeePhone;
        String Address = std.EmployeeAddress;
        int Age = std.EmployeeAge;
        ViewBag.ID = std.EmployeeID;
        ViewBag.Name = std.EmployeeName;
        ViewBag.Phone = std.EmployeePhone;
        ViewBag.Address = std.EmployeeAddress;
        ViewBag.Age = std.EmployeeAge;
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee std)
    {
       ViewBag.thongtinNhanVien = std.EmployeeID+ "-" + std.EmployeeName+ "-" + std.EmployeeAge;
        return View();
    }
   }
}