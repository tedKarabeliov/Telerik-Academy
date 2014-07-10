using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        char c = '\u00A9';
        int end = 1;
        int limit = 10;
        while (true)
        {
            for (int row = 1; row <= end; row++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            end++;
            if (end == limit)
            {
                return;
            }
        }

    }
}

