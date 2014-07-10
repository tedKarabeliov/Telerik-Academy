using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EraseRepeating
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder result = new StringBuilder();
        result.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                result.Append(text[i]);
            }
        }
        Console.WriteLine(result.ToString());
    }
}

