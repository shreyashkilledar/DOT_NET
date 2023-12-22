using System.Runtime.Serialization;
using Hardware;
namespace Transflower.Drawing;
public class Line : Shape,IPrinter

{

    public Point start{get;set;}
    public Point end{get;set;}

    public Line()
    {
        this.start= new Point(0,0);
        this.end=new Point(0,0);
    }

    public Line(Point p1, Point p2, string c, int w):base(c,w)
    {
        this.start=p1;
        this.end=p2;
    }
    public override void Draw()
    {
        Console.WriteLine("Draw the Line");
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return base.ToString()+ this.start+","+this.end;
    }

    public void print()
    {
        Console.WriteLine("Print the line");
    }
}