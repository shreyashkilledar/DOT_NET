namespace Transflower.Drawing;

public class Point
{
    public int X{get;set;}
    public int Y{get;set;}

    public Point()
    {
        this.X=0;
        this.Y=0;
    }

    public Point(int x,int y)
    {
        this.X=x;
        this.Y=y;
    }

    public override string ToString()
    {
        string str=string.Format("X={0},Y={0}",this.X,this.Y);
        return str;
    }
}