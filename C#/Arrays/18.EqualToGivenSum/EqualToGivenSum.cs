using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EqualToGivenSum
{
    static void Main()
    {
        int s = 14;
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        List<int> possibleSums = new List<int>();
        List<int> newPossibleSums = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            possibleSums.Add(arr[i]);
            if (arr[i] == s)
            {
                Console.WriteLine("Yes");
                return;
            }

            for (int k = 0; k < possibleSums.Count - 1; k++)
            {
                newPossibleSums.Add(possibleSums[k] + arr[i]);
            }
            for (int k = 0; k < newPossibleSums.Count; k++)
            {
                possibleSums.Add(newPossibleSums[k]);
                if (newPossibleSums[k] == s)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            newPossibleSums.Clear();
        }
        Console.WriteLine("No");

    }
}

