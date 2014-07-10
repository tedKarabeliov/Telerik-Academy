using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LargestNum
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        int binSearch = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            binSearch = Array.BinarySearch(arr, arr[i]);
            if (arr[binSearch] > k)
            {
                continue;
            }
            Console.WriteLine("Largest number which is <= K is " + arr[binSearch]);
            return;
        }
    }
}

