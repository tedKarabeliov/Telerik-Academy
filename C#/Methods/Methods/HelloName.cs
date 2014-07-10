using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HelloName
{
    static void CheckName(string name)
    {
        bool check = name.All(Char.IsLetter);
        if (check)
        {
            PrintName(name);
        }
        else
        {
            Console.WriteLine("Incorrect name");
            Console.WriteLine();
        }
    }

    static void PrintName(string name)
    {
        Console.Write("Hello, " + name + "!");
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        CheckName(name);
    }
}

