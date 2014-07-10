using System;
using System.Collections.Generic;
using System.Linq;
class MaxIncreasingSubsequence
{
    private static List<int> FindLongestSubsequenceOfEqualNumbers(List<int> list)
    {
        var foundNumbers = new List<KeyValuePair<int, int>>();
        var countEqualNumber = 0;
        var subsequenceValue = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if (i != 0 && list[i] != list[i - 1])
            {
                subsequenceValue = list[i - 1];
                foundNumbers.Add(new KeyValuePair<int, int>(subsequenceValue, countEqualNumber));
                countEqualNumber = 0;
            }

            countEqualNumber++;

            if (i == list.Count - 1)
            {
                if (list[i] == list[i - 1])
                {
                    subsequenceValue = list[i - 1];
                }
                else
                {
                    subsequenceValue = list[i];
                }
                foundNumbers.Add(new KeyValuePair<int, int>(subsequenceValue, countEqualNumber));
            }
        }

        var timesFound = foundNumbers.Max(o => o.Value);
        var numberFound = foundNumbers.Find(o => o.Value == timesFound).Key;
        var result = new List<int>();
        for (int i = 0; i < timesFound; i++)
        {
            result.Add(numberFound);
        }
        return result;
    }

    static void Main()
    {
        var list = new List<int> {1, 1, 1, 6, 6, 6, 6, 6, 6, 6, 2, 2, 3, 2, 2, 3, 3, 5};
        //var list = new List<int> {1, 2, 3, 4, 4, 5, 6, 6, 6};
        var longestSubsequenceofEqualNumbers = FindLongestSubsequenceOfEqualNumbers(list);
        var output = "";
        for (int i = 0; i < longestSubsequenceofEqualNumbers.Count; i++)
        {
            output += longestSubsequenceofEqualNumbers[i] + " "; 
        }
        Console.WriteLine("Longest Subsequence of Equal Numbers: " + output.Trim());
    }
}
