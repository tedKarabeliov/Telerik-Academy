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

        bool IsInCircle = x * x + y * y <= 5;
        bool IsInRectangle = (x >= -1 && y >= 1) && (x <= 5 && y <= 5);

        bool result = IsInCircle && IsInRectangle;
        Console.WriteLine("Is point in circle and in rectangle? " + result);

    }
}

