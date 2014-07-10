using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MaxSum_N_K
{
    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter number of elements which will have max sum:");
        int k = int.Parse(Console.ReadLine());
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        int sum = 0;
        int maxsum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < k && j < arr.Length;j++)
            {
                sum += arr[j];
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
            }
            sum = 0;
            k++;
        }
        Console.WriteLine("--> " + maxsum);
    }
}

