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
        int plusCount = 0;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Product is 0");
            return;
        }

        if (a > 0)
        {
            plusCount++;
        }
        if (b > 0)
        {
            plusCount++;
        }
        if (c > 0)
        {
            plusCount++;
        }
        if (plusCount % 2 == 0)
        {
            Console.WriteLine("Sign is \"-\"");
        }
        else
        {
            Console.WriteLine("Sign is \"+\"");
        }


        
    }
}

