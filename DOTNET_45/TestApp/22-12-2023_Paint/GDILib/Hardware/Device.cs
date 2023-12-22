

namespace Hardware;

public class Device : IPrinter, IScanner
{
    public void print()
    {
         Console.WriteLine("Printing the data");
    }

    public void scan()
    {
         Console.WriteLine("Scanning the data");
    }
}