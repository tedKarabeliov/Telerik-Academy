using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
class Matrix
{
    static int[,] ReadMatrix(string file)
    {
        StreamReader reader = new StreamReader(file);
        using (reader)
        {
            string line = reader.ReadLine();
            int matrixSize = int.Parse(line);
            string[] split = new string[matrixSize];
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                line = reader.ReadLine();
                split = line.Split(' ');
                for (int col = 0, i = 0; col < matrix.GetLength(1); col++, i++)
                {
                    matrix[row, col] = int.Parse(split[i]);
                }
            }
            return matrix;
        }
    }
    static void DisplayMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] matrix = ReadMatrix("file.txt");
        DisplayMatrix(matrix);
        int[,] sub = new int[2, 2];
        int sum = 0;
        int maxsum = 0;
        int memoryrow = 0;
        int memorycol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            memoryrow = row;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                memorycol = col;
                for (int subrow = 0; subrow <= 1; subrow++, row++)
                {
                    for (int subcol = 0; subcol <= 1; subcol++, col++)
                    {
                        sub[subrow, subcol] = matrix[row, col];
                        sum += sub[subrow, subcol];
                    }
                    col = memorycol;
                }
                row = memoryrow;
                if (sum > maxsum)
                {
                    maxsum = sum;
                }
                sum = 0;
            }
        }
        Console.WriteLine("\nBiggest 2x2 submatrix: " + maxsum);
    }
}
