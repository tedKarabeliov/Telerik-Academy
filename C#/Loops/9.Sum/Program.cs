using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static double Factorial(double n)
    {
        if (n == 1)
        {
            return n;
        }
        else
        {
            n = n * Factorial(n - 1);
        }
        return n;
    }
    static double Extent(double n, double ex)
    {
        if (ex == 1)
        {
            return n;
        }
        else
        {
            n = n * Extent(n, ex - 1);
            return n;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter n:");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += (Factorial(i)) / (Extent(x, i));
        }
    }
}

