using Microsoft.AspNetCore.Mvc;
using TranXuanTruong.Net.Models;
namespace TranXuanTruong.Net.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { PersonAge = 15, PersonAddress = "NamDinh",   PersonPhoneNumber = "0964220676"},
            new Person { PersonAge = 16, PersonAddress = "HaNoi",     PersonPhoneNumber = "0869246872"},
            new Person { PersonAge = 17, PersonAddress = "NinhBinh", PersonPhoneNumber = "0986324156"},
            new Person { PersonAge = 18, PersonAddress = "HaTinh",    PersonPhoneNumber = "0964220676"},
            new Person { PersonAge = 19, PersonAddress = "HaiPhong",    PersonPhoneNumber = "0964220676"},
        };
        ViewData["Person"] = StdList;
        ViewBag.ThongtinSV = StdList.Count();
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.PersonAge + "-" + std.PersonAddress + "-" + std.PersonPhoneNumber;
    return View();
    }
   }
}