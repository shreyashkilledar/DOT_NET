﻿
using Mathematics;
using Library;
using Utility;

//1. String printing as it is 
Books shelf =new Books();
Console.WriteLine(shelf.titles[1]);

//2. String printing replaced values
shelf[0]="Shreyash";
string b1=shelf[0];
Console.WriteLine(b1);

shelf[2]="Rutvik";
string b2=shelf[2];
Console.WriteLine(b2);

shelf[3]="Bhagyashri";
string b3=shelf[3];
Console.WriteLine(b3);

//3. Maths
Mathematics1 m2=new Mathematics1();
int answer= m2.Addition(45,22);
Console.WriteLine("Addition is "+answer);
int answer1=m2.Substraction(45,22);
Console.WriteLine("Substraction is "+answer1);


//4.Utility
int radius=5;
float area1,circum;
Utility1.Circle(radius,out area1, out circum);
Console.WriteLine("Area of the circle is "+area1+". The circumference of the circle is "+circum);

// int ? count=null;
// Nullable<int> amount=null;
// string name=null;
// Console.WriteLine(count);
/*Utility1.Shownames("Shreyash");
Utility1.Shownames("Bhagyashri","Ashok","Suryawanshi");
Utility1.Shownames("Rutvik",65,true,3.142f);*/


//5. Multiplication & Division
int x=5;
int y=6;
int result1;
Utility1.Multiplication(x,y,out result1);
Console.WriteLine("Multiplication is "+result1);

int x1=45;
int y1=9;
float answer3;
Utility1.Division(x1,y1,out answer3);
Console.WriteLine("Division is "+answer3);



