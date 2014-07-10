using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Sum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int length = input.Length;
        int sum = 0;
        for (int i = 0; i < length; i++)
        {
            sum += int.Parse(input[i]);
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}

