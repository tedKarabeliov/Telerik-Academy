using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int age,year;
        year = DateTime.Now.Year;
        Console.WriteLine("Current year: " + year);
        Console.WriteLine("My age is: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("In " + (year + 10) + " your age will be " + (age + 10));
    }
}

