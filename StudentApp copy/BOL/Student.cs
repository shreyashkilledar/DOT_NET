namespace BOL;

public class Student{

    public int Id{get;set;}
    
    public string Fname{get;set;}

    public string Lname{get;set;}

    public int Standard{get;set;}

    public Student()
    {
        this.Id = 0;
        this.Fname = null;
        this.Lname = null;
        this.Standard = 0;
    }

    public Student(int id,string fnm,string lnm,int std)
    {
        this.Id = id;
        this.Fname = fnm;
        this.Lname = lnm;
        this.Standard = std;
    }

}