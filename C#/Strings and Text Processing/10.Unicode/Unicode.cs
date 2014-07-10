using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Unicode
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(String.Format("\\u{0:x4}", (int)text[i]));
        }
        Console.WriteLine();

    }
}

