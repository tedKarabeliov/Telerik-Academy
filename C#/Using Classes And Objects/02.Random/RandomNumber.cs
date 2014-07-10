using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class RandomNumber
{
    static void Main()
    {
        Random random = new Random();
        int start = 100;
        int finish = 200;
        for (int counter = 1; counter <= 10; counter++)
        {
            Console.Write(random.Next(start, finish) + 1 + " ");
        }
    }
}

