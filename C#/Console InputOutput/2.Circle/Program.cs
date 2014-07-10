using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius of circle:");
        double r = double.Parse(Console.ReadLine());
        double p = 2 * Math.PI * r;
        double s = Math.PI * r * r;
        Console.WriteLine("Perimeter = " + p);
        Console.WriteLine("Area = " + s);

    }
}

