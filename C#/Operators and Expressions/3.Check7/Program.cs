using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        number /= 100;
        bool isSeven = false;

        Console.Write("Is the third number from right to left 7? ");
        if (number % 10 == 7)
        {
            isSeven = true;
            Console.Write(isSeven);
        }
        else
        {
            Console.Write(isSeven);
        }
        Console.WriteLine();

    }
}

