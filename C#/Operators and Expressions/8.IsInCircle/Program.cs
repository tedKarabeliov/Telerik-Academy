using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter \"x\" coordinate:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter \"y\" coordinate:");
        int y = int.Parse(Console.ReadLine());
        //radius = 5;
        bool IsInCircle = x * x + y * y <= 5;
        Console.WriteLine("Is point in circle? " + IsInCircle);

    }
}

