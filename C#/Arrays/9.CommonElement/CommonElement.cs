using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CommonElement
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        int count = 1;
        int maxcount = 0;
        int memoryElement = 0;
        int k = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //{ 4, 1, 1, 4, 2, 1 }
            for (int i1 = ++k; i1 < arr.Length; i1++)
            {
                if (arr[i] == arr[i1])
                {
                    count++;
                    if (count > maxcount)
                    {
                        maxcount = count;
                        memoryElement = arr[i];
                    }
                }
            }
            count = 1;
        }
        Console.Write("-- > " + memoryElement + " (" + maxcount + " times)\n");
    }
}

