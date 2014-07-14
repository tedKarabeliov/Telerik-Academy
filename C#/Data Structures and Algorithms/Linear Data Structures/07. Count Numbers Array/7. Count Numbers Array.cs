using System;
using System.Collections.Generic;

class CountNumbersArray
{
    private static SortedDictionary<int, int> CountNumbersInArray(int[] arr)
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
        return numbersByOccurences;
    }

    static void Main()
    {
        var arr = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        var numbersByOccurences = CountNumbersInArray(arr);

        foreach (var numberByOccurence in numbersByOccurences)
        {
            Console.WriteLine(numberByOccurence.Key + " -> " + numberByOccurence.Value + " times");
        }
    }
}
