using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MergeSort
{
    static int[] MergeSort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < arr.Length - middle; i++)
        {
            right[i] = arr[i + middle];
        }
        left = MergeSort(left);
        right = MergeSort(right);

        int leftptr = 0;
        int rightptr = 0;

        int[] sorted = new int[arr.Length];
        for (int k = 0; k < arr.Length; k++)
        {
            if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
            {
                sorted[k] = left[leftptr];
                leftptr++;
            }
            else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
            {
                sorted[k] = right[rightptr];
                rightptr++;
            }
        }
        return sorted;
    }

    static void Main()
    {
        int[] arr = { 5, 2, 8, 6, 9, 1, 3 };
        int[] result = MergeSort(arr);
        foreach (int show in result )
        {
            Console.Write(show + " ");
        }
    }
}

