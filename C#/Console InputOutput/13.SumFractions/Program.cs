using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        for (double i = 1,sum = 0,oldSum = 0;;i++)
        {
            oldSum = sum;
            sum += 1 / i;
            if ((sum - oldSum) < 0.001)
            {
                Console.WriteLine("Sum = " + sum);
                return;
            }
        }

    }
}

