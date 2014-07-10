using System;
using System.Collections.Generic;
class RemoveNegativeNumbers
{
    //5. Write a program that removes from given sequence all negative numbers.

    private static List<int> ReadInput()
    {
        List<int> list = new List<int>();
        string input = Console.ReadLine();

        while (input != "")
        {
            int currentNumber = int.Parse(input);
            list.Add(currentNumber);
            input = Console.ReadLine();
        }

        return list;
    }

    private static List<int> RemoveAllNegativeNumbers(List<int> list)
    {
        var result = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >= 0)
            {
                result.Add(list[i]);
            }
        }
        return result;
    }

    static void Main()
    {
        //var list = ReadInput();
        var list = new List<int> { 1, 5, -2, 4, -6, -7, 5 };
        var result = RemoveAllNegativeNumbers(list);
        var output = "";
        for (int i = 0; i < result.Count; i++)
        {
            output += result[i] + " ";
        }
        Console.WriteLine("Array after negative numbers removed: " + output.Trim());

    }
}
