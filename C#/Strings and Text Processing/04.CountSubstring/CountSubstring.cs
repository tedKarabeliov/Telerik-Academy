using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CountSubstring
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine("Given text\n{0}\n:", text);
        Console.Write("Find word: ");
        string substring = Console.ReadLine();
        text  = text.ToLower();
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == substring[0])
            {
                bool isMatch = true;
                for (int textIndex = i, substringIndex = 0; textIndex < text.Length && substringIndex < substring.Length; textIndex++, substringIndex++)
                {
                    if (text[textIndex] != substring[substringIndex])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch)
                {
                    count++;
                }
            }
        }
        Console.WriteLine("There are {0} matches for the word \"{1}\".", count, substring);
    }
}

