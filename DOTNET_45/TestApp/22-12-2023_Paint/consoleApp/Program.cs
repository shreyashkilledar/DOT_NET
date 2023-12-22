using Transflower.Drawing;
using Hardware;
using GDILib;
using System.Collections.Generic;

Device d=new  Device();
d.print();
d.scan();

List<Shape> s=new List<Shape>();

Line l=new Line();

l.start=new Transflower.Drawing.Point(14,15);
l.end=new Transflower.Drawing.Point(14,15);
l.color="red";
l.width=2;



Ellipse e=new Ellipse();
e.startpoint=new Transflower.Drawing.Point(10,20);
e.endpoint=new Transflower.Drawing.Point(10,20);

e.Draw();


Point center=new Point(45,54);
Circle c=new Circle(center, 15,"blue",3);
c.Draw();

s.Add(l);
s.Add(c);
s.Add(e);


Console.WriteLine("All shapes showing");
foreach( Shape s1 in s)
{
    Console.WriteLine(s1);
}