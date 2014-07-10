using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaxEqualNumbers
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        int length = 1;
        int maxLength = 0;
        int start = 0;
        int maxStart = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                start = arr[i];
                length++;
                if (length > maxLength)
                {
                    maxLength = length;
                    maxStart = start;
                }
            }
            else
            {
                length = 1;
            }
        }
        Console.Write("--> ");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxStart + " ");
        }
        Console.WriteLine();

    }
}

