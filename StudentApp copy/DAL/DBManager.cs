namespace DAL;
using MySql.Data.MySqlClient;

using BOL;

public static class DBManager{

    public static string conString = @"server=localhost;port=3306;user=root;password=Ssk@1234567;database=sk ";

    public static List<Student> GetAll()
    {
        List<Student> allstud = new List<Student>();

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from Students";
        try{
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Connection =con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
             {
                int id = int.Parse(reader["Id"].ToString());
                string fnm = reader["Fname"].ToString();
                string lnm = reader["Lname"].ToString();
                int standard = int.Parse(reader["Standard"].ToString());

                Student s = new Student(id,fnm,lnm,standard);
                if(s!=null)
                {
                  allstud.Add(s);
                }
             }

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
         return allstud;
    }

  //  public static void Insert(int id,string fname,string lname, int std)
    public static void Insert(Student s2)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "Insert into Students values(@Id,@Fname,@Lname,@Std)";
         
          try{
              MySqlCommand cmd= new MySqlCommand(query,con);
              cmd.Parameters.AddWithValue("@Id",s2.Id);
              cmd.Parameters.AddWithValue("Fname",s2.Fname);
              cmd.Parameters.AddWithValue("@Lname",s2.Lname);
              cmd.Parameters.AddWithValue("@Std",s2.Standard);

              cmd.Connection = con;
              con.Open();
              cmd.CommandText = query;
              cmd.ExecuteNonQuery();

          }catch(Exception e)
          {
             Console.WriteLine(e.Message);
          }finally{
                con.Close();
        }
   }

    public static void Edit(Student s3)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "Update table Students set Fname=@Fname1,Lname=@Lname1,Standard=@standard2 where Id = @Id1";
        try{
            MySqlCommand cmd = new MySqlCommand(query,con);
              cmd.Parameters.AddWithValue("@Id",s3.Id);
              cmd.Parameters.AddWithValue("Fname",s3.Fname);
              cmd.Parameters.AddWithValue("@Lname",s3.Lname);
              cmd.Parameters.AddWithValue("@Std",s3.Standard);
              
              cmd.Connection = con;
              con.Open();
              cmd.CommandText = query;
              cmd.ExecuteNonQuery();

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }


    }

}