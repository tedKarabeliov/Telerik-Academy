using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class IsLeap
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Is it leap? - ");
        Console.Write(DateTime.IsLeapYear(year));
        Console.WriteLine();
    }
}

