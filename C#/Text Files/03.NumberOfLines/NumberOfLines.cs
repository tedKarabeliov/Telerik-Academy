using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class NumberOfLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        List<string> memory = new List<string>();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                memory.Add(line);
                line = reader.ReadLine();
            }

        }
        StreamWriter writer = new StreamWriter("file.txt", false);
        using (writer)
        {
            for (int i = 0; i < memory.Count; i++)
            {
                writer.WriteLine("Line " + (i + 1) + ": " + memory[i]);
            }
        }
        memory.Clear();
    }
}

