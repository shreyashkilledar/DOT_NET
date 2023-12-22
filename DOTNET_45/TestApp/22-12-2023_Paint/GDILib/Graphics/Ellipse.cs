namespace Transflower.Drawing;
using Hardware;
public class Ellipse : Shape,IPrinter

{
    public Point startpoint{get;set;}
    public Point endpoint{get;set;}

    public Ellipse()
    {
        this.startpoint=new Point(0,0);
        this.endpoint=new Point(0,0);
    }

    public Ellipse(Point p1, Point p2, string c, int w):base(c,w)
    {
        this.startpoint=p1;
        this.endpoint=p2;
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing the Ellipse");
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return base.ToString()+ this.startpoint+","+this.endpoint;
    }

    public void print()
    {
      Console.WriteLine("Print the Ellipse");
    }
}