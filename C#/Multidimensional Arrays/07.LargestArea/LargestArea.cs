using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LargestArea
{
    static char[,] arr;
        //{
        //{'1','3','2','2','2','4'},
        //{'3','3','3','2','4','4'},
        //{'4','3','1','2','3','3'},
        //{'4','3','1','3','3','1'},
        //{'4','3','3','3','1','1'},
        //};
    static char num;
    static int count = 0;

    static List<int> counts = new List<int>();

    static void Move(int row, int col)
    {
        if (row < 0 || row >= arr.GetLength(0)
            || col < 0 || col >= arr.GetLength(1))
        {
            return;
        }

        if (arr[row, col] == '*')
        {
            return;
        }

        if (arr[row, col] != num)
        {
            return;
        }

        arr[row, col] = '*';
        count++;
        Move(row + 1, col); //down
        Move(row, col + 1); //right
        Move(row - 1, col); //up
        Move(row, col - 1); // left
    }

    static void Print()
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter rows:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns:");
        int n = int.Parse(Console.ReadLine());
        arr = new char[m, n];
        Console.WriteLine("Enter elements:");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = char.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                num = arr[row, col];
                Move(row, col);
                counts.Add(count);
                count = 0;
            }
        }

        Print();
        Console.WriteLine("-- > " + counts.Max());
        

    }
}

