namespace HR;
public class WageEmployee:Employee
{
    //private int hrs;
    public int Hrs{
        get;set;
    }  

    public WageEmployee(int id,String Fullname,int hrs):base(id,Fullname)
    {
        this.Hrs=hrs;

    }
    public WageEmployee():this(21,"Shreyash",60){

    }
    public override float ComputePay()
    {
        return base.ComputePay()+Hrs*60;
    }
    public override string ToString()
    {
        return base.ToString()+ "Hrs are "+Hrs;
    }
}
