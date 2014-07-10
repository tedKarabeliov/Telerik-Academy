using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        while (n != 0)
        {
            list.Add(n % 2);
            n /= 2;
        }
        list.Reverse();
        Console.Write("Result = ");
        foreach (int show in list)
        {
            Console.Write(show);
        }
        Console.WriteLine();
    }
}

