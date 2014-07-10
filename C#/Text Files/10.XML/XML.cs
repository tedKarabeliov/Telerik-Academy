using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class XML
{
    static string ReadFile(string file)
    {
        StreamReader reader = new StreamReader(file);
        string text;
        using (reader)
        {
            text = reader.ReadToEnd();
        }
        return text;
    }

    static void Main()
    {
        string text = ReadFile("file.txt");
        StringBuilder str = new StringBuilder(text);
        bool tag = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '<')
            {
                tag = true;
            }
            while (tag && i < str.Length)
            {
                if (str[i] == '>')
                {
                    tag = false;
                    i++;
                    break;
                }
                i++;
            }
            while (!tag && i < str.Length)
            {
                if (str[i] == '<')
                {
                    tag = true;
                    break;
                }
                Console.Write(str[i]);
                i++;
            }
        }
        Console.WriteLine();
    }
}

