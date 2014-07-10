using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MoreNeighbors
{
    static int CompareElements(int[] arr, int l)
    {
        for (int i = 1; i < l; i++)
        {
            if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
            {
                return arr[i];
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 10, 5, 2, 1, 15, 6, 10, 9 };
        int l = arr.Length - 1;
        Console.WriteLine("Given array: ");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine("\n");
        CompareElements(arr, l);
        if (CompareElements(arr, l) == -1)
        {
            Console.WriteLine("no number bigger than both neighbours");
        }
        else
        {
            Console.WriteLine("The first number which is bigger than both neighbours is "
                + CompareElements(arr, l) + "\n");
        }

    }
}
