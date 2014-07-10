using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static int[] ShuffleArray(int[] arr)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int j = random.Next(i);
            int k = arr[j];
            arr[j] = arr[i + 1];
            arr[i + 1] = k;
        }
        return arr;
    }

    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        ShuffleArray(arr);
        Console.Write("Shuffeled numbers --> ");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();

    }
}

