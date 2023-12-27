namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;


public class ProductManager
{
   public List<Product> GetAllProducts()
   {
      List<Product> allProducts = new List<Product>();
      allProducts = ProductDBManager.GetAllProducts();
      return allProducts;
   }

}