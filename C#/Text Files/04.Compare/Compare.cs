using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Compare
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("file1.txt");
        StreamReader reader2 = new StreamReader("file2.txt");
        string line1, line2;
        int counterEgual = 0;
        int counterDifferent = 0;
        using (reader1)
        {
            using (reader2)
            {
                while (true)
                {
                    line1 = reader1.ReadLine();
                    line2 = reader2.ReadLine();
                    if (line1 == null && line2 != null || line1 != null && line2 == null)
                    {
                        throw new ArgumentException("Both files' lines must be egual");
                    }
                    else if (line1 == null && line2 == null)
                    {
                        Console.WriteLine("Number of equal lines = " + counterEgual);
                        Console.WriteLine("Number of different lines = " + counterDifferent);
                        return;
                    }
                    if (line1 == line2)
                    {
                        counterEgual++;
                    }
                    else
                    {
                        counterDifferent++;
                    }

                }
            }
        }
    }
}
