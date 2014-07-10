using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter matrix's size:");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];
        int arrlength = arr.Length;
        int row = 0;
        int col = 0;
        int value = 1;

        for (; col < arr.GetLength(1); col++)
        {
            for (; row < arr.GetLength(0); row++)
            {
                arr[row, col] = value;
                value++;
            }
            row = 0;
        }
        col = 0;

        for (; row < arr.GetLength(0); row++)
        {
            for (; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            col = 0;
            Console.WriteLine();

        }

    }
}

