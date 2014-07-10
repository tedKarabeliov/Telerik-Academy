using System;
using System.Collections.Generic;
class MaxSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        int sum = 0;
        int maxsum = 0;
        int i = 0;

        for (int a = 0; a < arr.Length; a++)
        {
            i = a;
            for (; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
            }
            sum = 0;
        }
        Console.Write("--> " + maxsum);
        Console.WriteLine();

    }
}

