using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaxSeparatedSubSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number of array elements:");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }


        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }

        int[] f = new int[arr.Length];
        int[] back = new int[arr.Length];
        int bestF = 0;
        int bestIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            f[i] = back[i] = 1;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            for (int k = i - 1; k >= 0; k--)
            {
                if (arr[i] > arr[k])
                {
                    if (f[k] + 1 > f[i])
                    {
                        f[i] = f[k] + 1;
                        if (f[i] > bestF)
                        {
                            bestF = f[i];
                            bestIndex = i;
                        }
                        back[i] = k;
                    }
                }
            }
        }
        List<int> result = new List<int>();
        result.Add(arr[bestIndex]);
        Console.Write("--> { ");
        for (int i = bestIndex; back[i] != 1; i = back[i])
        {
            result.Add(arr[back[i]]);
        }
        result.Sort();
        foreach (int show in result)
        {
            Console.Write(show + " ");
        }
        Console.Write("}\n");

    }
}

