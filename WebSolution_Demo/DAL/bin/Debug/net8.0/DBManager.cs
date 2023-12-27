namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

using System.Collections.Generic;

public class ProductDBManager
{
        public static string conString="server=localhost;port=3306;user=root; password=Ssk@1234567;database=sk";       

        public static List<Product> GetAllProducts()
        {

              List<Product> allProducts=new List<Product>();
            //database connectivity code
            //Connected Data Access Mode
            //MySqlConnection  : establishing connection
            //MySqlCommand      : query execution
            //MySqlDataReader   : result of query to be catured after processing query
            MySqlConnection con=new MySqlConnection();
            con.ConnectionString=conString;
            try{
                con.Open();
                //fire query to database
                MySqlCommand cmd=new MySqlCommand();
                cmd.Connection=con;
                string query="SELECT * FROM products1";
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string description = reader["description"].ToString();
                    int qty = int.Parse(reader["qty"].ToString());
                    int price = int.Parse(reader["price"].ToString());


                    Product prod = new Product();
                    prod.Id =id;
                    prod.Name = name;
                    prod.Description = description;
                    prod.Qty = qty;
                    prod.Price = price;
                                        
                
                    allProducts.Add(prod);
                }
                reader.Close();
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return allProducts;  
        }       
}     