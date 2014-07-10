using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class ChangeCase
{
    static string ToUpper(string text)
    {
        int index = text.IndexOf("<upcase>");
        int index2 = text.IndexOf("</upcase>");
        string modify = text.Substring(index + 8, index2 - (index + 8));
        text = text.Replace(modify, modify.ToUpper());
        text = text.Remove(index, 8);
        index2 = text.IndexOf("</upcase>");
        text = text.Remove(index2, 9);
        return text;
    }

    static void Main()
    {
        string text = Console.ReadLine();
        int index1 = text.IndexOf("<upcase>");
        int index2 = text.IndexOf("</upcase>");
        while (index1 != -1 || index2 != -1)
        {
            text = ToUpper(text);
            index1 = text.IndexOf("<upcase>");
            index2 = text.IndexOf("</upcase>");
        }
        Console.WriteLine(text);
    }
}

