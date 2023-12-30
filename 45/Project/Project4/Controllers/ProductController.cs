using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project4.Models;
using System.Collections.Generic;
using BOL;
using DAL;
using BLL;


namespace Portal.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Product()
    {

        ProductManager mgr=new ProductManager();
        List<Product> allProducts=mgr.GetAllProduct();
        //View Data is a Dictionary Object
        //data is maintained inside dictionary using key - Value pair
        this.ViewData["prod1"]=allProducts;
        return View();
    }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
