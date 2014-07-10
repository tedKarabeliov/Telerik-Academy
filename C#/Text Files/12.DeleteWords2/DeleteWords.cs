using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class DeleteWords2
{
    static void Main()
    {
        try
        {
            StreamReader TextReader = new StreamReader("text.txt");
            StreamReader WordReader = new StreamReader("words.txt");
            string text;
            List<string> words = new List<string>();
            string line = WordReader.ReadLine();
            using (WordReader)
            {
                while (line != null)
                {
                    words.Add(line);
                    line = WordReader.ReadLine();
                }
            }
            using (TextReader)
            {
                text = TextReader.ReadToEnd();
                for (int i = 0; i < words.Count; i++)
                {
                    text = text.Remove(text.IndexOf(words[i]), words[i].Length);
                }
            }
            StreamWriter TextWriter = new StreamWriter("text.txt");
            using (TextWriter)
            {
                TextWriter.Write(text);
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

