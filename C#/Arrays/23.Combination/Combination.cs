using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Combination
{
    static void Check(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
    }

    static void Combine(int[] arr, int n, int i, int next)
    {
        if (i == arr.Length)
        {
            Check(arr);
            return;
        }

        for (int j = next; j < n; j++)
        {
            arr[i] = j;

            Combine(arr, n, i + 1, j + 1);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[int.Parse(Console.ReadLine())];

        Combine(arr, n, 0, 0);
    }

}

