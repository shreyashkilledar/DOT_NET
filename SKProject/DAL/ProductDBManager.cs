namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class ProductDBManager
{
    public static string conString=@"server=localhost;port=3306;user=root; password=Ssk@1234567;database=sk";
    public static List<Product> GetAllProduct()
    {
        List<Product> allproducts= new List<Product>();
        MySqlConnection con= new MySqlConnection();
        con.ConnectionString= conString;
        try
        {
            con.Open();
            MySqlCommand cmd= new MySqlCommand();
            cmd.Connection=con;
            string query="select * from project";
            cmd.CommandText=query;
            MySqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                int id= int.Parse(reader["id"].ToString());
                string name= reader["name"].ToString();
                double price=double.Parse(reader["price"].ToString());

                Product prod= new Product();
                prod.id=id;
                prod.name=name;
                prod.price=price; 
                allproducts.Add(prod);
            }
            
        }
        catch(Exception ee)
        {
                Console.WriteLine(ee.Message);
            }
        finally
        {
            con.Close();
        }
        return allproducts;
    }
}
