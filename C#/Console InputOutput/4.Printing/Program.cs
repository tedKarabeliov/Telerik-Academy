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
        string a = int.Parse(Console.ReadLine()).ToString("X");
        Console.WriteLine("Enter positive fraction number:");
        double b = double.Parse(Console.ReadLine());
        if (b % 1 == 0 || b <= 0)
        {
            throw new ArgumentException("Number must be positive fraction!");
        }
        double c = double.Parse(Console.ReadLine());
        if (c % 1 == 0 || c >= 0)
        {
            throw new ArgumentException("Number must be negative fraction!");
        }
        Console.Write("\n{0,-10} {1,-10} {2,-10}\n",a,Math.Round(b,2),Math.Round(c,2));

    }
}

