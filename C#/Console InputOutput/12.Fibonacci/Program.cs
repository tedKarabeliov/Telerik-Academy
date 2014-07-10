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
        for (ulong n = 100; 0 < n; n--)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }

    }
}

