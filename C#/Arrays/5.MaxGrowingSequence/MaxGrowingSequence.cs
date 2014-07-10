using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaxGrowingSequence
{
    static void Main()
    {
        int[] arr = { 3, 1, 3, 4,8,10, 2, 2, 3, 4, 5, 4 };
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        int length = 1;
        int maxLength = 0;
        int startindex = 0;
        int endindex = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //{ 3, 2, 3, 4, 2, 2, 3, 4, 5, 4 }
            if (arr[i] < arr[i + 1])
            {
                length++;
                if (length > maxLength)
                {
                    maxLength = length;
                    endindex = i + 1;
                }
            }
            else
            {
                length = 1;
            }
        }
        startindex = endindex - (maxLength - 1);
        Console.Write("--> ");
        for (int i = startindex; i <= endindex; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}

