using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ArraySort
{
    static void Swap(int[] arr, int a, int b)
    {
        int memory = arr[a];
        arr[a] = arr[b];
        arr[b] = memory;
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int k = i + 1; k < arr.Length; k++)
            {
                if (arr[i] > arr[k])
                {
                    Swap(arr, i, k);
                }
            }
        }
    }

    static void Main()
    {
        int[] arr = { 9, 8, 5, 7, 2, 1, 3 };
        Console.WriteLine("Given array:");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();

        SelectionSort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();

    }
}

