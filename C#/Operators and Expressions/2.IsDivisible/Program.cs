using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 35 == 0)
        {
            Console.WriteLine("Number is divisible by 5 and 7");
        }
        else
        {
            Console.WriteLine("Number is not divisible by 5 and 7");
        }

    }
}

