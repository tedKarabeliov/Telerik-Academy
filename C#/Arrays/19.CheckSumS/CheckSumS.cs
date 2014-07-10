using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CheckSumS
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter S:");
        int S = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K:");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements:");

        int[] arr = new int[N];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> possibleSums = new List<int>();
        List<int> countElements = new List<int>();

        int capacity = possibleSums.Capacity = 1;
        int count = 0;
        for (int i = 0,k = 0; i < arr.Length; i++,count = 0, capacity *= 2)
        {
            for (k = 0, possibleSums.Add(arr[i]),countElements.Add(1), count++; count < capacity; k++)
            {
                possibleSums.Add(possibleSums[k] + arr[i]);
                countElements.Add(countElements[k] + 1);
                if (possibleSums[possibleSums.Count - 1] == S && countElements[countElements.Count - 1] == K)
                {
                    Console.WriteLine("Found");
                    return;
                }
                count++;
            }
            if (arr[i] == S && K == 1)
            {
                Console.WriteLine("Found");
                return;
            }
        }
        Console.WriteLine("Not found");
    }
}

