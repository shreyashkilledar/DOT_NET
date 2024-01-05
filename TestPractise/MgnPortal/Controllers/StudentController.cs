using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MgnPortal.Models;
using services;
namespace MgnPortal.Controllers;

public class StudentController : Controller
{
    private IStudentServices _StudentServices;

    public StudentController(IStudentServices StudentServices)
    {
        _StudentServices = StudentServices;
    }

    public IActionResult Display() {

        var list = _StudentServices.DisplayStudentService();
        this.ViewData["display"] = list;
        return View();
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(int rollno, string fname, string lname) {
        Student std = new Student(rollno, fname, lname);
        var list = _StudentServices.AddStudentService(std);
        if (list)
        {
            this.ViewData["Res"] = "Added successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["Res"] = "Adding failed";
        return View();
    }

    [HttpGet]
    public IActionResult Delete() {
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int rollno){
        var list = _StudentServices.DeleteStudentService(rollno);
        if (list)
        {
            this.ViewData["Res"] = "Deleted successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["Res"] = "Deletion failed";
        return View();
    }
    [HttpGet]
    public IActionResult Edit() {
        return View();
    }
    [HttpPost]
    public IActionResult Edit(int rollno, string fname, string lname){
        Student std = new Student(rollno, fname, lname);
        var list = _StudentServices.UpdateStudentService(std);
        if (list)
        {
            this.ViewData["Res"] = "Updated successfully";
            return RedirectToAction("Display");
        }
        this.ViewData["Res"] = "Updation failed";
        return View();
    }

    [HttpGet]
    public IActionResult Details(int rollno){
        List<Student>lst = _StudentServices.DisplayStudentService();
        var list = lst.Find((e) => e.RollNo == rollno);
        // this.ViewData["list"] = list;
        return View(list);
    }
}
