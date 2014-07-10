using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int a = 7;
        int b = 6;
        if (a > b)
        {
            int memory = a;
            a = b;
            b = memory;
        }
    }
}

