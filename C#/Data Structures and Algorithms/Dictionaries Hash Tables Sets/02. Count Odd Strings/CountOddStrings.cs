using System;
using System.Collections.Generic;
class CountOddStrings
{
    static string[] ExtractOddStrings(string[] arr)
    {
        IDictionary<string, int> wordsAndCounts = new Dictionary<string, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            string currentWord = arr[i];
            if (wordsAndCounts.ContainsKey(currentWord))
            {
                wordsAndCounts[currentWord]++;
            }
            else
            {
                wordsAndCounts[currentWord] = 1;
            }
        }

        var result = new List<string>();

        foreach (var wordAndCount in wordsAndCounts)
        {
            if (wordAndCount.Value % 2 == 1)
            {
                result.Add(wordAndCount.Key);
            }
        }
        return result.ToArray();
    }

    static void Main()
    {
        var arr = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

        var result = ExtractOddStrings(arr);
        Console.Write("{ ");
        foreach (var word in result)
        {
            Console.Write(word + ", ");
        }
        Console.WriteLine("}");
    }
}
