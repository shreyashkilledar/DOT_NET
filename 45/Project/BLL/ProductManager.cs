namespace BLL;
using BOL;
using DAL;

public class ProductManager
{
    public List<Product> GetAllProduct()
    {
        List<Product> products= new List<Product>();
        products=ProductDBManager.GetAllProducts();
        return products;
    }
}