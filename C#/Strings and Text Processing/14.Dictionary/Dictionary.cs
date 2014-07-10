using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("Enter \"exit\" to exit");
        while (true)
        {
            bool hasFound = false;
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            word = word.ToLower();

            if (word == "exit")
            {
                return;
            }

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                if (word == pair.Key.ToLower())
                {
                    Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
                    hasFound = true;
                    break;
                }
            }
            
            if (!hasFound)
            {
                Console.WriteLine("Not found in dictionary");
            }
            Console.WriteLine();
        }
       

    }
}

