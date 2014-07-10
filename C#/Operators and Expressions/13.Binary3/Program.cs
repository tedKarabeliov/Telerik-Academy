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
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index of bit:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value:");
        int v = int.Parse(Console.ReadLine());
        if (v < 0 || v > 1)
        {
            throw new ArgumentException("Bit value must be 0 or 1 only!");
        }
        int i = 1;
        i = i << p;
        bool isMatch = (n & i) != 0;
        if (isMatch)
        {
            if (v == 0)
            {
                n = n ^ i;
                Console.WriteLine("--> " + n);
            }
            else
            {
                Console.WriteLine("--> " + n);
            }
        }
        else
        {
            if (v == 1)
            {
                n = n | i;
                Console.WriteLine("--> " + n);
            }
            else
            {
                Console.WriteLine("--> " + n);
            }
        }

    }
}



