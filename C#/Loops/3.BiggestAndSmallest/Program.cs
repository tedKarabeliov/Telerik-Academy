using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter count of the numbers:");
        int n = int.Parse(Console.ReadLine());
        int biggest = 0;
        int smallest = int.MaxValue;
        int number = 0;
        Console.WriteLine("Enter " + n + " numbers:");
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number > biggest)
            {
                biggest = number;
            }
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine("Biggest number = " + biggest);
        Console.WriteLine("Smallest number = " + smallest);

    }
}

