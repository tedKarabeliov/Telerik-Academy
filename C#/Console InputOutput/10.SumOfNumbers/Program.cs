using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers");
        int a = 0;
        int sum = 0;
        int i = int.Parse(Console.ReadLine());
        for (; 0 < i; i--)
        {
            a = int.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine("Sum of numbers = " + sum);

    }
}

