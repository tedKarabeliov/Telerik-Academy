using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        int p = 2 * a + 2 * b;
        int s = a * b;
        Console.WriteLine("Perimeter: " + p);
        Console.WriteLine("Area: " + s);

    }
}

