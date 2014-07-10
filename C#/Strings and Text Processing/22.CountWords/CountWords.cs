using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountWords
{
    static bool DoesRepeat(string[] text, string word, int i)
    {
        bool repeats = false;
        for (int k = 0; k < i; k++)
        {
            if (text[k] == text[i])
            {
                repeats = true;
                break;
            }
        }
        return repeats;
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] text = input.Split(' ');

        List<string> result = new List<string>();
        List<int> counts = new List<int>();

        for (int i = 0; i < text.Length; i++)
        {
            string word = text[i];
            if (DoesRepeat(text, word, i))
            {
                continue;
            }

            result.Add(text[i]);
            counts.Add(1);
            for (int k = i + 1; k < text.Length; k++)
            {
                if (text[k] == text[i])
                {
                    (counts[counts.Count - 1])++;
                }
            }
        }
        
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i] + " - " + counts[i] + " time(s)");
        }
    }
}

