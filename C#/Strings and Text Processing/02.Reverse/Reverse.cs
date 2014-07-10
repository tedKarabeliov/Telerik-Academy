using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Reverse
{
    static void ReverseString(string consolestring)
    {
        string reversedstring = "";
        for (int i = consolestring.Length - 1; i > -1; i--)
        {
            reversedstring += consolestring[i];
        }
        Console.WriteLine(reversedstring);
    }

    static void Main()
    {
        string consolestring = Console.ReadLine();
        ReverseString(consolestring);
    }
}

