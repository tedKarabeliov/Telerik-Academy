using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HexademicalToDecimal
{
    static void Main()
    {
        string x = Console.ReadLine();
        x = x.ToLower();

        int ost = 0;
        int sum = 0;
        int power = -1;
        int number = 0;
        for (int i = x.Length - 1; i > -1; i--)
        {
            switch (x[i])
            {
                case 'a': number = 10; break;
                case 'b': number = 11; break;
                case 'c': number = 12; break;
                case 'd': number = 13; break;
                case 'e': number = 14; break;
                case 'f': number = 15; break;
                default: number = x[i]; break;
            }

            power++;
            ost = number % 16;
            sum += ost * (int)Math.Pow(16, power);
        }
        Console.WriteLine(sum);
    }
}

