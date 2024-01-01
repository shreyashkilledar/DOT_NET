using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Animal.Models;
using BOL;
using BLL;
using DAL;

namespace Animal.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Product()
    {
        ProductManager mgr= new ProductManager();
        List<Product> allproducts= mgr.GetAllProduct();
        this.ViewData["prod1"]=allproducts;
        return View();
    }
     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}