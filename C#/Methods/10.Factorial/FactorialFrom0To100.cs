using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class FactorialFrom0To100
{
    static BigInteger Factorial(BigInteger n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
       
    }

    static void Main()
    {
        for (int n = 1; n <= 100; n++)
        {
            Console.WriteLine(Factorial(n));
        }
        
        
    }
}
