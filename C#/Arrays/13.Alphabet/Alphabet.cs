using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Alphabet
{
    static void Main(string[] args)
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.WriteLine("Enter word:");
        char[] word = Console.ReadLine().ToCharArray();
        for (int i = 0; i < word.Length; i++)
        {
            for (int i1 = 0; i1 < alphabet.Length; i1++)
            {
                if (word[i] == alphabet[i1])
                {
                    Console.WriteLine(word[i] +  "--> " + i1);
                    break;
                }
            }
        }
    }
}

