namespace HR;
public class Employee{
    private int id;

    public int Id{
        get{return this.id;}
        set{this.id=value;}
    }

    public String FullName{
        get;set;
    }

    public Employee(int id,string FullName)
    {
        this.id=id;
        this.FullName=FullName;
    }

    public Employee():this(21,"shreyash"){

    }
    public virtual float ComputePay()
    {
        return 5000;

    } 

    public override string ToString()
    {
        return "My id is "+id+".My full name is "+FullName+".";
    }
}