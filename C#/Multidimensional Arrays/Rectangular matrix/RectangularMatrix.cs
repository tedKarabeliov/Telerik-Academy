using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class RectangularMatrix
{
    static void Main()
    {
        Console.WriteLine("Type matrix length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Type matrix width: ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n < 3 || m < 3)
        {
            Console.WriteLine("Error: Matrix' length and width must be greater than 3!");
            Console.WriteLine();
        }
        else
        {
            int[,] arr = new int[n, m];
            int g0 = arr.GetLength(0);
            int g1 = arr.GetLength(1);
            int row = 0;
            int col = 0;
            int newrow = 0;
            int newcol = 0;
            int limitrow = 0;
            int limitcol = 0;
            int sum = 0;
            int maxsum = 0;

            Console.WriteLine("Enter elements: ");
            for (; row < g0; row++)
            {
                for (; col < g1; col++)
                {
                    arr[row, col] = int.Parse(Console.ReadLine());
                }
                col = 0;

            }
            row = 0;
            Console.WriteLine();
            Console.WriteLine("Entered matrix: ");
            Console.WriteLine();
            for (; row < g0; row++)
            {
                for (; col < g1; col++)
                {
                    Console.Write(arr[row, col] + " ");
                }
                col = 0;
                Console.WriteLine();

            }
            row = 0;

            for (; row < g0 - 1; row++)
            {
                newrow = row;
                limitrow = row + 3;
                if (limitrow - 1 > g0 - 1)
                {
                    break;
                }
                for (; col < g1 - 1; col++)
                {
                    newcol = col;
                    limitcol = col + 3;
                    if (limitcol - 1 > g1 - 1)
                    {
                        col = 0;
                        newcol = col;
                        break;
                    }
                    for (; newrow < limitrow; newrow++)
                    {
                        for (; newcol < limitcol; newcol++)
                        {
                            sum += arr[newrow, newcol];
                            if (sum > maxsum)
                            {
                                maxsum = sum;
                            }
                        }
                        newcol = col;
                    }
                    newrow = row;
                    sum = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maximum sum of (3x3) submatrix in current matrix: " + maxsum);
            Console.WriteLine();
        }
    }
}

