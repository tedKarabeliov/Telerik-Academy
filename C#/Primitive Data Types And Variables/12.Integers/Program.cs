using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int a = 136;
        int b = 212;

        //Change numbers
        int memory;
        memory = a;
        a = b;
        b = memory;
        
        Console.WriteLine("Number \"a\" = " + a);
        Console.WriteLine("Number \"b\" = " + b);
    }
}

