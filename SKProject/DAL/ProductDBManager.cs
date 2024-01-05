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

     //Insert
    public static bool insert(Product p)
    {
        bool status=false;
        string query="insert into project (id,name,price)"+"values ("+p.id+","+p.name+","+p.price")";
        MySqlConnection con= new MySqlConnection();
        con.ConnectionString= conString;
        try
        {
            con.Open();
            MySqlCommand cmd= new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            status=true;
        }
        catch (Exception ee)
        {
            throw ee;
        }
        finally
        {
            con.Close();
        }
        return status;
    }


    //Update
    public static bool Update(Product p)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "UPDATE project SET price=" + p.price + ", name=" + p.name + " WHERE id=" + p.id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }


    //Delete
    public static bool Delete(int id){
        bool status=false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "DELETE FROM project WHERE id=" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
      return status;
    }
}


