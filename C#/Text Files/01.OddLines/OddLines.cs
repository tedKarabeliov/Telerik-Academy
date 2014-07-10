using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("test.txt");
        using (reader)
        {
            int counter = 2;
            string line = reader.ReadLine();
            Console.WriteLine(line);

            while (line != null)
            {
                if (counter % 2 == 0)
                {
                    reader.ReadLine();
                    counter++;
                    continue;
                }
                counter++;
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}

