using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class QuickSort
{
    static void Quicksort(int[] arr, int left, int right)
    {
        int i = left, k = right;
        int pivot = arr[(left + right) / 2];

        while (i <= k)
        {
            while (arr[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (arr[k].CompareTo(pivot) > 0)
            {
                k--;
            }

            if (i <= k)
            {
                // Swap
                int tmp = arr[i];
                arr[i] = arr[k];
                arr[k] = tmp;

                i++;
                k--;
            }
        }

        // Recursive calls
        if (left < k)
        {
            Quicksort(arr, left, k);
        }

        if (i < right)
        {
            Quicksort(arr, i, right);
        }
    }


    static void Main()
    {
        int[] arr = { 5, 3, 2, 8, 7, 6, 1, 9, 4 };
 
        // Print the unsorted array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
 
        Quicksort(arr, 0, arr.Length - 1);
 
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
 
        Console.WriteLine();
    }     
}


