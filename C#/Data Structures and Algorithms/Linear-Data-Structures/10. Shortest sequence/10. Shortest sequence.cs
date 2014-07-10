using System;
using System.Collections.Generic;
class Shortestsequence
{
    private static void PrintShortestSequence(int n, int m)
    {
        var list = new List<int>();
        var prevousIndexes = new List<int>();
        list.Add(n + 1);
        list.Add(n + 2);
        list.Add(n * 2);
        prevousIndexes.Add(-1);
        prevousIndexes.Add(-1);
        prevousIndexes.Add(-1);

        var resultIndex = list.IndexOf(m, list.Count - 3);
        for (int i = 0; resultIndex == -1; i++)
        {
            var currentNumber = list[i];

            list.Add(currentNumber + 1);
            prevousIndexes.Add(i);
            list.Add(currentNumber + 2);
            prevousIndexes.Add(i);
            list.Add(currentNumber * 2);
            prevousIndexes.Add(i);

            resultIndex = list.IndexOf(m, list.Count - 3);
        }

        var result = new List<int>();
        while (resultIndex != -1)
        {
            result.Add(list[resultIndex]);
            resultIndex = prevousIndexes[resultIndex];
        }
        result.Add(n);

        var output = "";
        for (int i = result.Count - 1; i >= 0; i--)
        {
            output += result[i] + " -> ";
        }
        Console.WriteLine("Shortest sequence: " + output.Substring(0, output.Length - 4));
    }

    static void Main()
    {
        Console.WriteLine("Enter start value");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter final value");
        var m = int.Parse(Console.ReadLine());
        PrintShortestSequence(n, m);
    }
}
