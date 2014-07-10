using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers:");
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int k = 0;

        while (k < arr.Length)
        {
            for (int i = k; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == 0)
                {
                    Console.Write("Found subset --> ");
                    for (; k <= i; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    Console.WriteLine();
                    return;
                }
            }
            k++;
            sum = 0;
        }
        Console.WriteLine("No subset with sum = 0 found");


    }
}

