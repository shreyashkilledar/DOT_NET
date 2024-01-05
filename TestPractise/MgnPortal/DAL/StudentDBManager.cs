using MySql.Data.MySqlClient;
namespace dal;
public static class StudentDBManager{
    static string conString = "server=192.168.10.150; port=3306; user=dac4; password=welcome; database=dac4";
    public static List<Student>? DisplayStudentsDao(){
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from studentiet";
        MySqlCommand cmd = new MySqlCommand(query, con);
        List<Student> sList = new List<Student>();
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student();
                s.RollNo = int.Parse((reader["rollno"]).ToString());
                s.Fname = reader["fname"].ToString();
                s.Lname = reader["lname"].ToString();
                sList.Add(s);
            }
            return sList;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
        finally{
            con.Close();
        }
    } 

    public static bool AddNewStudentDao(Student std)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "INSERT INTO studentiet(rollno,fname,lname) VALUES('"+std.RollNo+"','"+std.Fname+"','"+std.Lname+"')"; 
        MySqlCommand cmd = new MySqlCommand(query,con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
            return false;
        }
        finally{
            con.Close();
        }
    }
    public static bool UpdateStudentDao(Student std)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "UPDATE studentiet SET rollno='"+std.RollNo+"', fname='"+std.Fname+"', lname='"+std.Lname+"'WHERE rollno='"+std.RollNo+"'"; 
        MySqlCommand cmd = new MySqlCommand(query,con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
            return false;
        }
        finally{
            con.Close();
        }
    }
    public static bool DeleteStudentDao(int rollno)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "DELETE FROM studentiet WHERE rollno='"+rollno+"'"; 
        MySqlCommand cmd = new MySqlCommand(query,con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.Message);
            return false;
        }
        finally{
            con.Close();
        }
    }

}