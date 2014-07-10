using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HexademicalToBinary
{
    static void Main()
    {
        string x = Console.ReadLine();
        x = x.ToLower();
        char[] hexademical = {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f'};
	    string[] binary = {"0000","0001","0010","0011","0100","0101","0110","0111","1000","1001","1010","1011","1100","1101","1110","1111"};

	    for (int i = 0; i < x.Length; i++)
	    {
		    for (int k = 0; k < 16; k++)
		    {
			    if (x[i] == hexademical[k])
			    {
				    if (i == 0)
				    {
                        Console.Write(binary[k]);
				    }
				    else
				    {
                        Console.Write(binary[k]);
				    }
				    break;
			    }
		    }
	    }
    }
}

