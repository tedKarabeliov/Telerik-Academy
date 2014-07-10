using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinaryToDecimal
{
    static void Main()
    {
        string x = Console.ReadLine();
        int ost = 0;
        int sum = 0;
        int power = -1;
        for (int i = x.Length - 1; i > -1; i--)
        {
            if (x[i] != '0' && x[i] != '1')
            {
                return;
            }
            power++;
            ost = (x[i] - '0') % 10;
            sum += ost * (int)Math.Pow(2, power);
        }
        Console.WriteLine(sum);
    }
}

