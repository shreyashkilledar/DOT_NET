namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

using System.Collections.Generic;

public class ProductDBManager
{
        public static string conString="server=192.168.10.150;port=3306;user=dac44; password=welcome;database=dac44";       

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
                string query="SELECT * FROM product45   ";
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int Product_Id = int.Parse(reader["Product_Id"].ToString());
                    string Product_Name = reader["Product_Name"].ToString();
                    double Product_Price = double.Parse(reader["Product_Price"].ToString());


                    Product prod = new Product();
                    prod.Product_Id =Product_Id;
                    prod.Product_Name = Product_Name;
                    prod.Product_Price = Product_Price;
                                        
                
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
