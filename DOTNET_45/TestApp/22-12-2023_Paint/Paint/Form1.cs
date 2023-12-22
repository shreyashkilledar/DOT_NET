using Transflower.Drawing;
using System.Drawing;
namespace Paint;

public partial class Form1 : Form
{
    Transflower.Drawing.Point startpoint;
    Transflower.Drawing.Point endpoint;
    public Form1()
    {
        InitializeComponent();
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);   
        MouseDown+=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+=new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

      public void OnPaint(object sender, PaintEventArgs e){
       
    }

    public void onMouseDown(object sender, MouseEventArgs e){
      
       startpoint=new Transflower.Drawing.Point(e.X, e.Y);
	}

     public void onMouseUp(object sender, MouseEventArgs e){
        endpoint=new Transflower.Drawing.Point(e.X, e.Y);
        Line l=new Line(startpoint, endpoint,"red",3);
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.start.X, l.start.Y, l.end.X, l.end.Y);
    }
}
