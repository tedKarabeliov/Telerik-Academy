using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        ulong a = 1;
        ulong b = 1;
        ulong c = 0;
        Console.WriteLine("Enter limit of the sequence:");
        for (ulong n = ulong.Parse(Console.ReadLine()); 0 < n; n--)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
        Console.WriteLine();

    }
}

