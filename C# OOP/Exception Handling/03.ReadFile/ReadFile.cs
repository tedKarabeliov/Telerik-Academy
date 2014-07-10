using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class ReadFile
{
    static void Main()
    {
        string path = @"C:\Windows\win.ini";
        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
       
        catch (ArgumentException)
        {
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path to file is too long");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized Access");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (NotSupportedException)
        {
        }
    }
}

