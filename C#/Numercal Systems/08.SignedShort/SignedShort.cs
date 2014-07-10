using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SignedShort
{
    static void Main()
    {
        short input = short.Parse(Console.ReadLine());
        short x = input;
        if (x == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] result = new int[16]; ;
            for (int i = 0; i < 16; i++)
            {
                result[i] = 2;
            }
            for (int i = 15; i != 0; i--)
            {
                result[i] = Math.Abs(x % 2);
                x /= 2;
            }
            x = input;
            if (x < 0)
            {
                result[0] = 1;
            }
            else
            {
                result[0] = 0;
            }

            for (int i = 0; i < 16; i++)
            {
                if (result[i] != 0)
                {
                    while (true)
                    {
                        Console.Write(result[i]);
                        i++;
                        if (i == 16)
                        {
                            i = 16;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

