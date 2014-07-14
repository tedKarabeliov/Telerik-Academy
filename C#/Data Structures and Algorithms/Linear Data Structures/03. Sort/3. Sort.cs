using System;
using System.Collections.Generic;
using System.Linq;
class Sort
{
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

    private static List<int> SortList(List<int> list)
    {
        var sorted = new List<int>(list.Count);
        while (list.Count != 0)
        {
            var currentMinNumberIndex = list.IndexOf(list.Min());
            sorted.Add(list[currentMinNumberIndex]);
            list.RemoveAt(currentMinNumberIndex);
        }
        return sorted;
    }

    //Write a program that reads a sequence of integers (List<int>) ending
    //with an empty line and sorts them in an increasing order.
    
    static void Main()
    {
        var list = ReadInput();
        var sorted = SortList(list);
        var output = "";
        for (int i = 0; i < sorted.Count; i++)
        {
            output += sorted[i] + " ";
        }
        Console.WriteLine("Sorted: " + output.Trim());
    }

    
}
