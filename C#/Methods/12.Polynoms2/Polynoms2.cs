using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Polynoms2
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
    static int[] Substract(int[] arr1, int[] arr2)
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
                result[i] = arr1[i] - arr2[i];
            }
        }
        return result;
    }
    static int[] Multiply(int[] arr1, int[] arr2)
    {
        int[] power1 = new int[arr1.Length];
        int[] power2 = new int[arr2.Length];

        for (int i = 0; i < power1.Length; i++)
        {
            power1[i] = i;
        }
        for (int i = 0; i < power2.Length; i++)
        {
            power2[i] = i;
        }

        List<int> Calculate = new List<int>();
        List<int> powerCalculate = new List<int>();
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int k = 0; k < arr2.Length; k++)
            {
                Calculate.Add(arr1[i] * arr2[k]);
                powerCalculate.Add(power1[i] + power2[k]);
            }
        }
        List<int> result = new List<int>();
        for (int count = 0; count <= powerCalculate.Max(); count++)
        {
            int sum = 0;
            for (int i = 0; i < powerCalculate.Count; i++)
            {
                if (powerCalculate[i] == count)
                {
                    sum += Calculate[i];
                }
            }
            result.Add(sum);
        }
        return result.ToArray();
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
        int[] result = Multiply(arr1, arr2);
    
    }
}

