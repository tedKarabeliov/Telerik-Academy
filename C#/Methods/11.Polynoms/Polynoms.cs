using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Polynoms
{
    static int[] Add(int[] arr1, int[] arr2)
    {
        int[] result = new int[Math.Max(arr1.Length, arr2.Length)];

        for (int i = 0; i < result.Length; i++)
        {
            if (i == arr1.Length)
            {
                while (i < result.Length)
                {
                    result[i] = arr2[i];
                    i++;
                }
            }
            else if (i == arr2.Length)
            {
                while (i < result.Length)
                {
                    result[i] = arr1[i];
                    i++;
                }
            }
            else
            {
                result[i] = arr1[i] + arr2[i];
            }
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter highest power of first polynom:");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n + 1];
        Console.WriteLine("Enter first polynom's elements, starting from the highest power:");
        for (int i = arr1.Length - 1; i >= 0; i--)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter highest power of second polynom:");
        int m = int.Parse(Console.ReadLine());

        int[] arr2 = new int[m + 1];
        Console.WriteLine("Enter second polynom's elements, starting from the highest power:");
        for (int i = arr2.Length - 1; i >= 0; i--)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        int[] result = Add(arr1, arr2);
    }
}

