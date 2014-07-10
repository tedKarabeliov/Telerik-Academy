using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Dates
{
    static void Main()
    {
        Console.Write("Enter date in format \"dd.mm.yyyy\" ");
        string[] input1 = Console.ReadLine().Split('.');

        Console.Write("Enter date in format \"dd.mm.yyyy\" ");
        string[] input2 = Console.ReadLine().Split('.');

        DateTime date1 = new DateTime(int.Parse(input1[2]), int.Parse(input1[1]), int.Parse(input1[0]));
        DateTime date2 = new DateTime(int.Parse(input2[2]), int.Parse(input2[1]), int.Parse(input2[0]));
        TimeSpan distance = date2 - date1;
        double result = distance.Days;
        Console.WriteLine("Distance: " + result + " days");
        
    }
}

