using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class KelementsNnumbers
{
    static void Generator(int n, int index, int[] arr)
    {
        if (index == -1)
        {
            Print(arr);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                Generator(n, index - 1, arr);
            }
        }
    }
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Enter number limit:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array limit:");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        Generator(n, k - 1, arr);
    }
}

