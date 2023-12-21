using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using cataloge;

namespace webApp1.Controllers;

public class productcontroller : Controller
{
    private readonly ILogger<productcontroller> _logger;

    public productcontroller(ILogger<productcontroller> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        Product p1=new Product();
        p1.pname="Jasmine";
        p1.pdesc="Smelling Flower";
        p1.qty=56;
        p1.price=7999;
        p1.Imageurl="/images/R1.png";
        p1.Imageurl="/images/R3.png";
  
        ViewData["flower"]=p1;
        return View();
    }
}