using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountLetters
{
    static bool DoesRepeat(string input, char letter, int i)
    {
        bool repeats = false;
        for (int k = 0; k < i; k++)
        {
            if (input[k] == input[i])
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

        List<char> result = new List<char>();
        List<int> counts = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            if (letter == ' ')
            {
                continue;
            }
            if (DoesRepeat(input, letter, i))
            {
                continue;
            }

            result.Add(input[i]);
            counts.Add(1);
            for (int k = i + 1; k < input.Length; k++)
            {
                if (input[k] == input[i])
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

