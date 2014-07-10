using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Max
{
    static int GetMax(int number1, int number2)
    {
        int max = number1;
        if (number2 > number1)
        {
            max = number2;
        }
        return max;
    }

    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(GetMax(first, second), third));

    }
}

