using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class BigNumbers
{
    static void Sum(string num1, string num2)
    {
        if (num1.Length > 10000 || num2.Length > 10000)
        {
            throw new ArgumentOutOfRangeException("Number too large");
        }
        int[] arr1 = new int[10000];
        int[] arr2 = new int[10000];
        int[] result = new int[10000];
        string sum = null;
        for (int i = 0, k = num1.Length - 1; k >= 0; i++,k--)
        {
            arr1[i] = (int)Char.GetNumericValue(num1[k]);
        }

        for (int i = 0, k = num2.Length - 1; k >= 0; i++,k--)
        {
            arr2[i] = (int)Char.GetNumericValue(num2[k]);
        }
        result[0] = (arr1[0] + arr2[0]) % 10;
        int ost = (arr1[0] + arr2[0]) / 10;
        for (int i = 1; i <= Math.Max(num1.Length, num2.Length); i++)
        {
            result[i] = (arr1[i] + arr2[i]) % 10 + ost;
            ost = (arr1[i] + arr2[i]) / 10;
            if (i == Math.Max(num1.Length, num2.Length) - 1 && ost != 0)
            {
                result[i + 1] = ost;
            }
        }
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (result[i] != 0)
            {
                while (i >= 0)
                {
                    Console.Write(result[i]);
                    i--;
                }
                break;
            }
            
        }
    }

    static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        Sum(num1, num2);
    }
}

