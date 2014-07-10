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
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());
        if (1 >= k || k >= n)
        {
            Console.WriteLine("1<K<N!");
            return;
        }
        Console.WriteLine("Result = " + (Factorial(n) * Factorial(k)) / Factorial (n - k));
    }
}

