using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h");
        double h = double.Parse(Console.ReadLine());
        double s = ((a + b) / 2) * h;
        Console.WriteLine("Area is " + s);
    }
}

