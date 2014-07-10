using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class DecimalToHexademical
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
            int[] result = new int[10];
			int ost = 0;
			for (int i = 9; i > -1; i--)
			{
				while (x != 0)
				{
					ost = x % 16;
					result[i] = ost;
					x /= 16;
					i--;
					if (x == 0)
					{
						i = -1;
						break;
					}
				}
                for (int k = 0; k < 10; k++)
				{
                    if (result[k] != 0)
					{
                        while (k < 10)
						{
                            switch (result[k])
							{
								case 10: Console.Write('A'); break;
                                case 11: Console.Write('B'); break;
                                case 12: Console.Write('C'); break;
                                case 13: Console.Write('D'); break;
                                case 14: Console.Write('E'); break;
                                case 15: Console.Write('F'); break;
                                default: Console.Write(result[k]); break;
							}
                            k++;
						}
					}
				}
			}
		}
    }
}

