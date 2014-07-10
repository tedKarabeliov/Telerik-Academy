using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concat = hello + " " + world;
        string result = concat.ToString();
        Console.WriteLine(result);

    }
}

