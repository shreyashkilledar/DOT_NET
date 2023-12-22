namespace Transflower.Drawing;
public abstract class Shape
{
    public string color{get;set;}
    public int width{get;set;}

    public Shape()
    {
        this.color="red";
        this.width=2;
    }

    public Shape(string c,int w)
    {
        this.color=c;
        this.width=w;
    }

    public abstract void Draw();

    public override string ToString()
    {
         return "Width="+ this.width + ",  Color="+this.color; 
    }
}