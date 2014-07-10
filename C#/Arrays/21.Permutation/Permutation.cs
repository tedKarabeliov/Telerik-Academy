using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Permutation
{
    static void Check(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
    }

    static void Permutate(int[] arr, bool[] used, int i)
    {
        if (i == arr.Length)
        {
            Check(arr);
            return;
        }

        for (int j = 0; j < arr.Length; j++)
        {
            if (used[j]) continue;

            arr[i] = j;

            used[j] = true;
            Permutate(arr, used, i + 1);
            used[j] = false;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number:");
        int[] arr = new int[int.Parse(Console.ReadLine())];

        bool[] used = new bool[arr.Length];
        Permutate(arr, used, 0);
    }

}

