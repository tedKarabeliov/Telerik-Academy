using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DecimalToBinary
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x == 0)
		{
            Console.WriteLine(0);
		}
		else
		{
            int[] result = new int[32]; ;
			for (int i = 0; i < 32; i++)
			{
				result[i] = 2;
			}
			for (int i = 31; x != 0; i--)
			{
				result[i] = x % 2;
				x /= 2;
			}
			for (int i = 0; i < 32; i++)
			{
				while (result[i] != 2)
				{
                    Console.Write(result[i]);
					i++;
					if (i == 32)
					{
						i = 32;
						break;
					}
				}
			}
            Console.WriteLine();
		}
    }
}

