using System;
using System.Collections.Generic;

//Write a program that removes from given sequence all numbers that occur
//odd number of times.

class RemoveNumbersOddTimes
{
    private static List<int> RemoveNumbersThatOccureOddTimes(int[] arr)
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

        var result = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            var currentNumber = arr[i];
            if (numbersByOccurences[currentNumber] % 2 == 0)
            {
                result.Add(currentNumber);
            }
        }
        return result;
    }

    static void Main()
    {
        var arr = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        var result = RemoveNumbersThatOccureOddTimes(arr);
        var output = "";
        for (int i = 0; i < result.Count; i++)
        {
            output += result[i] + " ";
        }
        Console.WriteLine("Result: " + output.Trim());
    }
}
