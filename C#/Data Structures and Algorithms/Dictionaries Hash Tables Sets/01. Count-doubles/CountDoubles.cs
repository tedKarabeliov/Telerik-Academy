using System;
using System.Collections.Generic;
class CountDoubles
{
    static IDictionary<double, int> CountDoublesInArray(double[] arr)
    {
        IDictionary<double, int> result = new Dictionary<double, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            double currentNumber = arr[i];
            if (result.ContainsKey(currentNumber))
            {
                result[currentNumber]++;
            }
            else
            {
                result[currentNumber] = 1;
            }
        }

        return result;
    }

    static void Main()
    {
        var arr = new double[]
        { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

        var result = CountDoublesInArray(arr);
        foreach (var numberAndValue in result)
        {
            Console.WriteLine(numberAndValue.Key + " -> " + numberAndValue.Value);
        }
    }
}
