using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReverseNumber
{
    static int ReversedNumber(int n)
    {
        Console.Write("Reversed number: ");
        int divide;
        for (int i = 0; ; i++)
        {
            divide = n % 10;
            n /= 10;
            Console.Write(divide);
            if (n == 0)
            {
                n.ToString();
                return n;
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        ReversedNumber(n);
        Console.WriteLine();
    }
}

