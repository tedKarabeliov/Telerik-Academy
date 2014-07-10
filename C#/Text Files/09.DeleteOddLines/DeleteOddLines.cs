using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        List<string> memory = new List<string>();
        int counter = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            if (line == null)
            {
                return;
            }
            counter++;
            while (true)
            {
                if (line == null)
                {
                    break;
                }
                if (counter % 2 == 1)
                {
                    line = reader.ReadLine();
                    counter++;
                    continue;
                }
                memory.Add(line);
                line = reader.ReadLine();
                counter++;

            }
        }
        StreamWriter writer = new StreamWriter("file.txt");
        using (writer)
        {
            for (int i = 0; i < memory.Count; i++)
            {
                writer.WriteLine(memory[i]);
            }
        }
    }
}

