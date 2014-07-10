using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ForbiddenWords
{
    static string ForbidWords(string text)
    {
        string memorytext = text;
        string memoryword;
        text = text.ToLower();
        int length = text.Length;
        int forbiddenwordlength;
        string forbiddenwords = "c#,clr,microsoft";
        string[] forbiddenarray = forbiddenwords.Split(',');
        for (int i = 0; i < forbiddenarray.Length; i++)
        {
            int isforbidden = text.IndexOf(forbiddenarray[i]);
            if (isforbidden != -1)
            {
                forbiddenwordlength = forbiddenarray[i].Length;
                memoryword = forbiddenarray[i];
                forbiddenarray[i] = forbiddenarray[i].Remove(0);
                for (int letter = 0; letter < forbiddenwordlength; letter++)
                {
                    forbiddenarray[i] += '*';
                }
                text = text.Replace(memoryword, forbiddenarray[i]);
            }
        }
        return text;
    }

    static void Main()
    {
        string text = "Microsoft announced its next generation C# compiler today. It uses advances parser and special optimizer for the Microsoft CLR.";
        Console.WriteLine(ForbidWords(text));
    }
}

