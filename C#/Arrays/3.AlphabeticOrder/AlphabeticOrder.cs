using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AlphabeticOrder
    static void Main()
    {
        Console.WriteLine("Enter 2 words:");
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < word1.Length; i++)
        {
            sum1 += word1[i];
        }
        for (int i1 = 0; i1 < word2.Length; i1++)
        {
            sum2 += word2[i1];
        }
        if (sum1 > sum2)
        {
            Console.WriteLine(word2 + " is alphabetically smaller");
        }
        else if (sum1 < sum2)
        {
            Console.WriteLine(word1 + " is alphabetically smaller");
        }
        else
        {
            Console.WriteLine("Both words are even");
        }

    }
}

