using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your weight(in kg):");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = (17 * weight) / 100;
        Console.WriteLine("Your weight on the Moon will be: " + moonWeight + "kg");


    }
}

