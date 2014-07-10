using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Concatenate
{
    static void Main()
    {
        StreamReader file1reader = new StreamReader("file1.txt");
        StreamReader file2reader = new StreamReader("file2.txt");
        StreamWriter resultwriter = new StreamWriter("result.txt", false);
        string line1 = file1reader.ReadLine();
        string line2 = file2reader.ReadLine();
        using (file1reader)
        using (file2reader)
        using (resultwriter)
        {
            {
                {
                    while (line1 != null && line2 != null)
                    {
                        resultwriter.WriteLine(line1 + line2);
                        line1 = file1reader.ReadLine();
                        line2 = file2reader.ReadLine();
                    }

                }
            }
        }

    }
}

