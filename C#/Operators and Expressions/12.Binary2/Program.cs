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

        int i = 1;
        i = i << p;
        bool isMatch = (n & i) != 0;
        if (isMatch)
        {
            Console.WriteLine("--> " + isMatch);
        }
        else
        {
            Console.WriteLine("--> " + isMatch);
        }

    }
}



