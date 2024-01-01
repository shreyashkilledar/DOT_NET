namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;
public class ProductManager
{
    public List<Product> GetAllProduct()
    {
        List<Product> allproducts= new List<Product>();
        allproducts= ProductDBManager.GetAllProduct();
        return allproducts;
    }

}
