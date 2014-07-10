using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int ace = 14;


        for (int two = 2; two <= ace; two++)
        {
            for (int spatiq = 1, pika = 4; spatiq <= pika; spatiq++)
            {
                Console.Write(two);
                Console.Write(spatiq + "\n");
            }
        }



    }
}

