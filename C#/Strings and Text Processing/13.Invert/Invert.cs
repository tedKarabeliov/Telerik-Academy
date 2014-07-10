using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Invert
{
    static string ReverseText(string text)
    {
        string[] split = text.Split(' ');
        string result = null;
        string[] reversed = new string[split.Length];
        int length = reversed.Length;
        for (int i = 0; i < length; i++)
        {
            reversed[i] = split[split.Length - i - 1];
            result = result + reversed[i] + " ";
        }
        Console.Write("Reversed: ");
        return result;
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine(ReverseText(text));

    }
}

