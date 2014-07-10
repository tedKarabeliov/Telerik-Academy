using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Palindromes
{
    static string ReverseString(string consolestring)
    {
        StringBuilder reversedstring = new StringBuilder();
        for (int i = consolestring.Length - 1; i > -1; i--)
        {
            reversedstring.Append(consolestring[i]);
        }
        return reversedstring.ToString();
    }

    static void Main()
    {
        string input = "Here are lamal some exe palindromes ABBA";
        string[] text = input.Split(' ');
        List<string> result = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Equals(ReverseString(text[i]), StringComparison.InvariantCultureIgnoreCase))
            {
                result.Add(text[i]);
            }
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}

