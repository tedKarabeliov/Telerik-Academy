using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SortStrings
{
    static string[] Sort(string[] arr)
    {
        List<string> result = new List<string>();
        int[] letterCount = new int[arr.Length];
        bool[] isMin = new bool[arr.Length];
        int letter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr[i].Length; k++)
            {
                letter++;
            }
            letterCount[i] = letter;
            letter = 0;
        }

        int count = 0;
        int min = int.MaxValue;
        while (count < arr.Length)
        {
            for (int i = 0; i < letterCount.Length; i++)
            {
                if (letterCount[i] < min)
                {
                    if (isMin[i] == true)
                    {
                        continue;
                    }
                    min = letterCount[i];
                }
            }
            for (int i = 0; i < letterCount.Length; i++)
            {
                if (letterCount[i] == min)
                {
                    isMin[i] = true;
                    result.Add(arr[i]);
                }
            }
            min = int.MaxValue;
            count++;
        }
        return result.ToArray();
    }


    static void Main()
    {
        string[] arr = { "abc","abcd","a","abcded", "a", "ab" };
        string[] sorted = Sort(arr);

    }
}

