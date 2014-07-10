using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;
        Console.Write("\n({0},{1}) ",a,b);
        for (; a <= b; a++)
        {
            if (a % 5 == 0)
            {
                counter++;
            }
        }
        Console.Write("--> " + counter + "\n");


    }
}

