using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using BOL;
using BLL;

namespace StudentApp.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Student> s1 = Manager.GetAll();
         
        ViewData["stud"]=s1;
        return View();
    }
    

      [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }
      [HttpPost]
    public IActionResult Insert(int i1,string fname,string lname, int std)
    {
        Manager.Insert(i1,fname,lname,std);
           return this.Redirect("/Student/Index");
    }

    
    [HttpGet]
    public IActionResult Edit()
    {
        return View();
    }
       
    [HttpPost]
    public IActionResult Edit(int i1,string fname,string lname, int std)
    {
        Manager.Edit(i1,fname,lname,std);
      //  return View();
        return this.Redirect("/Student/Index");
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
