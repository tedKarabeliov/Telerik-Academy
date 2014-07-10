using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader wordsReader = new StreamReader("words.txt");
            StreamReader testReader = new StreamReader("test.txt");
            List<string> resultWords = new List<string>();
            List<int> resultCount = new List<int>();
            using (wordsReader)
            {
                using (testReader)
                {
                    string word = wordsReader.ReadLine();
                    while (word != null)
                    {
                        testReader.BaseStream.Position = 0;
                        string testLine = testReader.ReadLine();
                        int count = 0;
                        while (testLine != null)
                        {
                            string[] arr = testLine.Split(' ');
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] == word)
                                {
                                    count++;
                                }
                            }
                            testLine = testReader.ReadLine();
                        }
                        resultWords.Add(word);
                        resultCount.Add(count);
                        word = wordsReader.ReadLine();
                    }
                }
            }
            int[] arrResultCount = resultCount.ToArray();
            string[] arrResultWords = resultWords.ToArray();
            Array.Sort(arrResultCount, arrResultWords);

            StreamWriter resultWriter = new StreamWriter("result.txt");
            using (resultWriter)
            {
                for (int i = arrResultCount.Length - 1; i >= 0; i--)
                {
                    resultWriter.WriteLine(arrResultWords[i] + " - " + arrResultCount[i] + "\n");
                }
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

