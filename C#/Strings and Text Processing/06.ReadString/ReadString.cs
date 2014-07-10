using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReadString
{
    static void Main()
    {
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            throw new ArgumentException("Text must be 20 characters max");
        }
        text = text.PadRight(20, '*');
        Console.WriteLine(text);

    }
}

