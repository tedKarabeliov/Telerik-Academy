using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinarySearch
{
    static int n = int.Parse(Console.ReadLine());
    static int[] arr = { 5, 2, 7, 8, 7, 9, 3, 1 };


    static void BinSearch(int start, int end)
    {
        if (start == end - 1 || end == start - 1)
        {
            Console.WriteLine("Not Found!");
            return;
        }

        if (arr[0] == n || arr[arr.Length - 1] == n || arr[(start + end) / 2] == n)
        {
            if (arr[0] == n)
            {
                Console.WriteLine("Found at position 0");
            }
            else if (arr[arr.Length - 1] == n)
            {
                Console.WriteLine("Found at position " + (arr.Length - 1));
            }
            else
            {
                Console.WriteLine("Found at position " + (start + end) / 2);
            }
            return;
        }

        if (n < arr[(start + end) / 2])
        {
            BinSearch(start, (start + end) / 2);
        }
        else if (n > arr[(start + end) / 2])
        {
            BinSearch((start + end) / 2, end);
        }
    }

    static void Main()
    {
        Array.Sort(arr);
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();

        int start = 0;
        int end = arr.Length - 1;
    
        BinSearch(start, end);
    }
}

