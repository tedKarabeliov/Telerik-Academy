using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static int BiggestFrom3Numbers(int a, int b, int c)
    {
        if (a > b && a > c)
        {
            return a;
        }
        else if (b > a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }

    }

    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Biggest number = " + BiggestFrom3Numbers(BiggestFrom3Numbers(a, b, c), d, e));
    }
}

