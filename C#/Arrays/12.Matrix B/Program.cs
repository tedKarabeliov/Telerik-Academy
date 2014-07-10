using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size:  \n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] arr = new int[n, n];
        int g0 = arr.GetLength(0);
        int g1 = arr.GetLength(1);
        int a = 1;
        int col = 0;
        int row = 0;

        for (; col < g1; col++)
        {
            if (row == g0 - 1)
            {
                for (; row > -1; row--)
                {
                    arr[row, col] = a;
                    a++;
                }
                row = 0;
            }
            else
            {
                for (; row < g0; row++)
                {
                    arr[row, col] = a;
                    a++;
                }
                row--;
            }
        }
        row = 0;
        col = 0;
        for (; row < g0; row++)
        {
            for (; col < g1; col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            col = 0;
            Console.WriteLine();
        }
    }
}

