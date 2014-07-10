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
        int fac = Factorial(n);
        int counter = 0;
        Console.WriteLine("Number = " + fac);
        while (fac % 10 == 0)
        {
            counter++;
            fac /= 10;
        }
        Console.WriteLine(counter + " zero(s) at the end of the number");
    }
}

