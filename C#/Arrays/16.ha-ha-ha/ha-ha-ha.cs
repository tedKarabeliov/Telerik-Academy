using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string[,] arr =
        {
        {"ha","fifi","ho","hi"},
        {"fo","ha","hi","xx"},
        {"xxx","ho","ha","xx"}
        };
        int g0 = arr.GetLength(0);
        int g1 = arr.GetLength(1);
        int result = 1;
        int maxresult = 1;
        string show = "null";

        Console.WriteLine("Current matrix: \n");
        for (int row = 0; row < g0; row++)
        {
            for (int col = 0; col < g1; col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int row = 0; row < g0; row++)
        {
            int memoryrow = row;
            for (int col = 0; col < g1; col++)
            {
                int memorycol = col;
                for (; col < g1 - 1; col++)
                {
                    if (arr[row, col] == arr[row, col + 1])
                    {
                        result++;
                        if (result > maxresult)
                        {
                            maxresult = result;
                            show = arr[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                result = 1;
                col = memorycol;
                for (; row < g0 - 1; row++)
                {
                    if (arr[row, col] == arr[row + 1, col])
                    {
                        result++;
                        if (result > maxresult)
                        {
                            maxresult = result;
                            show = arr[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                result = 1;
                row = memoryrow;
                for (; row < g0 - 1 & col < g1 - 1; row++, col++)
                {
                    if (arr[row, col] == arr[row + 1, col + 1])
                    {
                        result++;
                        if (result > maxresult)
                        {
                            maxresult = result;
                            show = arr[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                result = 1;
                row = memoryrow;
                col = memorycol;
                //!
                for (; row < g0 - 1 & col > 0; row++, col--)
                {
                    if (arr[row, col] == arr[row + 1, col - 1])
                    {
                        result++;
                        if (result > maxresult)
                        {
                            maxresult = result;
                            show = arr[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                result = 1;
                row = memoryrow;
                col = memorycol;
            }

        }
        Console.Write("--> ");
        for (; 0 < maxresult; maxresult--)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();
    }
}

