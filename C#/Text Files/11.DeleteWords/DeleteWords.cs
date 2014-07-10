using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
class DeleteWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        StreamWriter writer = new StreamWriter("result.txt");
        string line = "";

        using (reader)
        {
            using (writer)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}

