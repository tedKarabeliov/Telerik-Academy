using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Sorted numbers: ");
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c + " ");
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else
        {
            Console.WriteLine(c + " " + b + " " + a);
        }

    }
}

