using System;
using System.Collections.Generic;
class Sequence
{
    private static List<int> GenerateSequence(int n)
    {
        const int SequenceLimit = 50;

        var queue = new Queue<int>();
        var result = new List<int>();
        queue.Enqueue(n);
        while (result.Count < SequenceLimit)
        {
            var currentNumber = queue.Dequeue();
            queue.Enqueue(currentNumber + 1);
            queue.Enqueue((2 * currentNumber) + 1);
            queue.Enqueue(currentNumber + 2);
            result.Add(currentNumber);
        }

        return result;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var result = GenerateSequence(n);
        var output = "";
        for (int i = 0; i < result.Count; i++)
        {
            output += result[i] + " ";
        }
        Console.WriteLine("Generated sequence: " + output.Trim());
    }
}
