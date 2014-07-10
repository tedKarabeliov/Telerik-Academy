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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is biggest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is biggest");
            }
            else
            {
                Console.WriteLine(c + " is biggest");
            }

        }
    }

