using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Names
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        string line = "";
        List<string> list = new List<string>();
        using (reader)
        {
            while (true)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                list.Add(line);
            }
        }
        list.Sort();
        StreamWriter writer = new StreamWriter("result.txt");
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }
        }

    }
}

