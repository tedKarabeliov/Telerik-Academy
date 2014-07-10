using System;
using System.Collections.Generic;
class Majorant
{
    //The majorant of an array of size N is a value that occurs
    //in it at least N/2 + 1 times. Write a program to find the
    //majorant of given array (if exists).

    private static void FindMajorant(int[] arr)
    {
        var numbersByOccurences = new SortedDictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            var currentNumber = arr[i];
            if (numbersByOccurences.ContainsKey(currentNumber))
            {
                numbersByOccurences[currentNumber]++;
            }
            else
            {
                numbersByOccurences.Add(currentNumber, 1);
            }
        }

        foreach (var numberByOccurence in numbersByOccurences)
        {
            if (numberByOccurence.Value >= ((arr.Length / 2) + 1))
            {
                Console.WriteLine("Majorant found: " + numberByOccurence.Key);
                return;
            }
        }
        Console.WriteLine("No majorant found");
    }

    static void Main()
    {
        var arr = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
        FindMajorant(arr);
    }
}
