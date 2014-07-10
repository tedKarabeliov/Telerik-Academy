using System;
using System.Collections.Generic;
class CountWordsInText
{
    static IDictionary<string, int> CountWords(string text)
    {
        var wordsAndCounts = new Dictionary<string, int>();

        var arr = text.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < arr.Length; i++)
        {
            var currentWord = arr[i];
            currentWord = currentWord.ToLower();

            if (wordsAndCounts.ContainsKey(currentWord))
            {
                wordsAndCounts[currentWord]++;
            }
            else
            {
                wordsAndCounts[currentWord] = 1;
            }
        }

        return wordsAndCounts;
    }

    static void Main()
    {
        var text = "This is the TEXT. Text, text, text - THIS TEXT! Is this the text?";
        var wordsAndCounts = CountWords(text);

        foreach (var wordAndCount in wordsAndCounts)
        {
            Console.WriteLine(wordAndCount.Key + " -> " + wordAndCount.Value);
        }
    }
}
