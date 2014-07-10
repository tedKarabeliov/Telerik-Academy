using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17.Write a program to return the string with
//maximum length from an array of strings. Use LINQ.


namespace ArrayOfStrings
{
    class ArrayOfStrings
    {
        static void Main()
        {
            string[] arr = { "long", "longerrrrrr", "longest" };

            var maxLength = arr.Max(word => word.Length);

            var result =
                from word in arr
                where word.Length == maxLength
                select word;

            foreach (var word in result)
            {
                Console.WriteLine(word);
                break;
            }
        }
    }
}
