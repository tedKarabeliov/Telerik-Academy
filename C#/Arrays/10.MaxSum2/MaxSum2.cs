using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaxSum2
{
    static void Main()
    {
        int[] arr = { 57, 13, 5, 5, 1, 1, 78 };
        Console.WriteLine("Enter number \"n\": ");
        Console.WriteLine();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("{ ");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.Write("}, n = " + n + " ");

        int sum = 0;
        int i = 0;
        int a = 0;
        for (; a < arr.Length; a++)
        {
            i = a;
            for (; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == n)
                {
                    Console.Write("--> { ");
                    for (; a <= i; a++)
                    {
                        Console.Write(arr[a] + " ");
                    }
                    Console.Write("}");
                    a = 2147483646;
                    break;
                }
            }
            sum = 0;
        }
        if (a != 2147483647)
        {
            Console.Write("--> {  No sum found }");
        }
        Console.WriteLine();
    }
}

