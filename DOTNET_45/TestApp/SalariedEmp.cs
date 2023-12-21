using System.Numerics;

namespace HR;
public class SalariedEmp:WageEmployee
{
public float Incentives
{
    get;set;
}
public float Target
{
    get;set;
}
 public static int count;
 public SalariedEmp(int id,String Fullname,int hrs,float Incentives,float Target):base(id,Fullname,hrs)
 {
    this.Incentives=Incentives;
    this.Target=Target;
 }
 public SalariedEmp():this(1,"Shreyash",80,7000,80000)
 {
    count++;
 }
public override float ComputePay()
{
    float Total_Sal;
    if(Target>80000)
    {
        Total_Sal=base.ComputePay()+Incentives;
    }
    else
    {
        Total_Sal=base.ComputePay();
    }
    return Total_Sal;
}
    public override string ToString()
    {
        return base.ToString()+ " Incentives is "+Incentives+" .Target is "+Target+".My Total Salary is "+Total_Sal;
    }

     ~ SalariedEmp(){
        count--;
  
    }
    
}
