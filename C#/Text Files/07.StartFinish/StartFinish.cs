using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class StartFinish
{
    static void Main()
    {
        StreamReader reader = new StreamReader("file.txt");
        string text;
        using (reader)
        {
            text = reader.ReadToEnd();
        }
        text = text.Replace("start", "finish");
        StreamWriter writer = new StreamWriter("file.txt", false);
        using (writer)
        {
            writer.Write(text);
        }
    }
}

