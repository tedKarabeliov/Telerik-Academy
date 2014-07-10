using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PrintWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] text = input.Split(' ');
        Array.Sort(text);
        foreach (string show in text)
        {
            Console.WriteLine(show);
        }


    }
}

