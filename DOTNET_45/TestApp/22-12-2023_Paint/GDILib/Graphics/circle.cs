using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;

namespace Transflower.Drawing;
using Hardware;

public class Circle : Shape,IPrinter
{

    public Point centre{get;set;}
    public int radius{get;set;}

    public Circle()
    {
        this.centre=new Point(0,0);
        this.radius=4;
    }
    public Circle(Point c1,int r,string c,int w):base(c,w)
    {
        this.centre=c1;
        this.radius=r;
    }
    public override string ToString()
    {
        float pi=3.14f;
        float ans=pi*radius*radius;
        return base.ToString()+this.centre+" ,"+this.radius+" ans="+ans;


    }
    public override void Draw()
    {
        Console.WriteLine("Draw the circle");
        Console.WriteLine(this);
        
    }

    public void print()
    {
        Console.WriteLine("Print the circle");
    }
}