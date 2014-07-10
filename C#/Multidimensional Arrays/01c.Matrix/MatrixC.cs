using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MatrixC
{
    static void Main()
    {
        Console.WriteLine("Enter matrix's size:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int num = 1;

        for (int row = arr.GetLength(0) - 1; row >= 0; row--)
        {
            int rowCount = row;
            int colCount = 0;
            while (rowCount != arr.GetLength(0))
            {
                arr[rowCount, colCount] = num;
                num++;
                rowCount++;
                colCount++;
            }
        }

        for (int col = 1; col < arr.GetLength(1); col++)
        {
            int rowCount = 0;
            int colCount = col;
            while (colCount != arr.GetLength(1))
            {
                arr[rowCount, colCount] = num;
                num++;
                rowCount++;
                colCount++;
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

