using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        for (int i = 2,changeSign = 1; i <= 101; i++)
        {
            Console.Write(i * changeSign + " ");
            changeSign *= -1;
        }
        Console.WriteLine();

    }
}

