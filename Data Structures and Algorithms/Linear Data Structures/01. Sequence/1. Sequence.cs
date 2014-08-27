using System;
using System.Collections.Generic;
class Sequence
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

    private static int CalculateSum(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum;
    }

    private static int CalculateAverage(List<int> list)
    {
        int sum = CalculateSum(list);
        int average = sum / list.Count;
        return average;
    }

    static void Main()
    {
        List<int> list = ReadInput();
        int sum = CalculateSum(list);
        int average = CalculateAverage(list);

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}
