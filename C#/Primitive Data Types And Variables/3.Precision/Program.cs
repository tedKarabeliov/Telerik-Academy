using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        decimal number = Decimal.Parse(Console.ReadLine());
        Console.WriteLine("Rounded number with precision 0.000001: " + Math.Round(number,6));
    }
}

