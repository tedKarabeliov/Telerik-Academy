using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix's size:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int num = 1;
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                arr[row, col] = num;
                num++;
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

