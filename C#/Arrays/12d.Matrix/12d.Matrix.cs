using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix
{
    static int n = int.Parse(Console.ReadLine());
    static int[,] arr = new int[n, n];
    static int num = 1;

    static void GoDown(int row, int col)
    {
        if (row == n || row == -1)
        {
            return;
        }
        if (col == n || col == -1)
        {
            return;
        }
        if (arr[row, col] != 0)
        {
            return;
        }
        arr[row, col] = num;
        num++;
        GoDown(row + 1, col);
        GoRight(row, col + 1);
    }
    static void GoRight(int row, int col)
    {
        if (row == n || row == -1)
        {
            return;
        }
        if (col == n || col == -1)
        {
            return;
        }
        if (arr[row, col] != 0)
        {
            return;
        }
        arr[row, col] = num;
        num++;
        GoRight(row, col + 1);
        GoUp(row - 1, col);
    }
    static void GoUp(int row, int col)
    {
        if (row == n || row == -1)
        {
            return;
        }
        if (col == n || col == -1)
        {
            return;
        }
        if (arr[row, col] != 0)
        {
            return;
        }
        arr[row, col] = num;
        num++;
        GoUp(row - 1, col);
        GoLeft(row, col - 1);

    }
    static void GoLeft(int row, int col)
    {
        if (row == n || row == -1)
        {
            return;
        }
        if (col == n || col == -1)
        {
            return;
        }
        if (arr[row, col] != 0)
        {
            return;
        }
        arr[row, col] = num;
        num++;
        GoLeft(row, col - 1);
        GoDown(row + 1, col);
    }

    static void Main()
    {
        int row = 0;
        int col = 0;
        GoDown(row, col);

        for (int printRow = 0; printRow < n; printRow++)
        {
            for (int printCol = 0; printCol < n; printCol++)
            {
                Console.Write(arr[printRow, printCol] + " ");
            }
            Console.WriteLine();
        }

    }
}

