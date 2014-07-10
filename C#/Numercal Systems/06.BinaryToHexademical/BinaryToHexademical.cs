using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BinaryToHexademical
{
    static void Main()
    {
        string x = Console.ReadLine();
        if (x == "0")
	    {
		    Console.WriteLine(0);
	    }
	    else
	    {
            
		    int[] binary = {0,1,10,11,100,101,110,111,1000,1001,1010,1011,1100,1101,1110,1111};
		    string[] hexademical = {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
            string[] result = new string[20];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = "*";
            }

            string number = null;
		    int resultindex = -1;
		    for(int i = x.Length - 1; i > -1;)
		    {
			    if (i < 4)
			    {
				    int k = 0;
				    while (k <= i)
				    {
					    number += x[k];
					    k++;
				    }
			    }
			    else
			    {
				    for (int k = i - 3; k < x.Length && k <= i; k++)
				    {
					    number += x[k];
				    }
			    }
			
			    for(int k = 0; k < 16; k++)
			    {
				    if (Convert.ToInt32(number) == binary[k])
				    {
					    resultindex++;
					    result[resultindex] = hexademical[k];
					    number = "";
					    break;
				    }
			    }
			    i -= 4;
		    }

		    for (int i = 19; i > -1; i--)
		    {
			    if (result[i] != "*")
			    {
				    while (i > - 1)
				    {
                        Console.Write(result[i]);
					    i--;
				    }
			    }
		    }
	    }

    }
}

