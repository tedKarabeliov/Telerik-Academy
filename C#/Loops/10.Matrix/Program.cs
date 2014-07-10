using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        if (n >= 20)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        int[,] arr = new int[n, n];
        int i = 1;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++,i++)
            {
                arr[row, col] = i;
                Console.Write(arr[row,col] + " ");
            }
            Console.WriteLine();
        }


    }
}

