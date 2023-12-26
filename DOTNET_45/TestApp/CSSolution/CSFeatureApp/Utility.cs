using Mathematics;
namespace Utility;

public static class Utility1
{
    public static void Swap(ref int num1, ref int num2)
    {
        int temp;
        temp=num1;
        num1=num2;
        num2=temp;
    }

    public static void Circle(int radius, out float area, out float circumference)
    {
        float pie=3.142f;
        area= pie*radius*radius;
        circumference=2*pie*radius;
    }

    public static void Multiplication(int x, int y, out int result)
    {
        result=x*y;
    }

    public static void Division(int x1, int y1, out float answer2)
    {
        answer2=x1/y1;
    }
    

}	
