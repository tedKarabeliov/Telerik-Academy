using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Brackets
{
    static bool CheckBrackets(string consolestring)
    {
        int counteropen = 0;
        int counterclose = 0;
        for (int i = 0; i < consolestring.Length; i++)
        {
            if (consolestring[i] == '(')
            {
                counteropen++;
            }
            if (consolestring[i] == ')')
            {
                counterclose++;
            }
        }
        if (counteropen != counterclose)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main()
    {
        string consolestring = Console.ReadLine();
        Console.WriteLine(CheckBrackets(consolestring));


    }
}

