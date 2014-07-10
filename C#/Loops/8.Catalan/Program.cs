using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static int Factorial(int n)
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

    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        Console.WriteLine("Result = " + (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n)));



    }
}

