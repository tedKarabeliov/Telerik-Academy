using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class NumAppearInArray
{
    static int CheckCount(int[] arr, int l, int n)
    {
        int counter = 0;
        for (int i = 0; i < l; i++)
        {
            if (arr[i] == n)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements:");
        int m = int.Parse(Console.ReadLine());
        int[] arr = new int[m];
        Console.WriteLine("Enter elements:");
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Given array:");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Number " + n + " consists " + CheckCount(arr, m, n) + " times in given array");

    }
}

