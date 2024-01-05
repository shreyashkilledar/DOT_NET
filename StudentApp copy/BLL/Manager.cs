namespace BLL;
using BOL;
using DAL;


public class Manager{

    public static List<Student> GetAll()
    {
      List<Student> allstud= DBManager.GetAll();
      
    //   foreach(Student a in allstud)
    //   {
    //     Console.WriteLine(a.Id);
    //   }
       
       return allstud;
    }

    public static void Insert(int id,string fname,string lname, int std)
    {
          Student s1 = new Student(id,fname,lname,std);
          DBManager.Insert(s1);

    }

    public static void Edit(int id,string fname,string lname, int std)
    {
          Student s1 = new Student(id,fname,lname,std);
          DBManager.Edit(s1);

    }
}