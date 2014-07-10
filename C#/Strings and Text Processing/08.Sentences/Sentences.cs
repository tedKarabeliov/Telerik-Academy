using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Sentences
{
    static void FindGivenWord(string text)
    {
        text = text.ToLower();
        string[] sentences = text.Split('.');
        int length = sentences.Length;
        int result;
        string word = Console.ReadLine();
        Console.WriteLine("Sentences which have word \"{0}\":", word);
        for (int i = 0; i < length; i++)
        {
            result = sentences[i].IndexOf(" " + word + " ");
            if (result == -1)
            {
                result = sentences[i].IndexOf(" " + word);
                if (result == -1)
                {
                    continue;
                }
            }
            sentences[i] = sentences[i].Trim();
            Console.WriteLine(sentences[i] + ".");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all day. We will move out of it in 5 days.";
        Console.WriteLine("Given text:\n" + text);
        FindGivenWord(text);

    }
}

