using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TraverseDirectory
{
    class TraverseDirectory
    {
        public static void PrintExeFiles(string directory)
        {
            var foundFiles = Directory.GetFiles(directory).Where(
                d => d.EndsWith(".exe", StringComparison.OrdinalIgnoreCase));
            foreach (var file in foundFiles)
            {
                Console.WriteLine(file);
            }

            var childDirectories = Directory.GetDirectories(directory);
            foreach (var dir in childDirectories)
            {
                try
                {
                    PrintExeFiles(dir);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine("File is restricted");
                }
                
            }
        }

        static void Main()
        {
            var windowsDirectory = @"C://Windows";
            PrintExeFiles(windowsDirectory);
        }
    }
}
