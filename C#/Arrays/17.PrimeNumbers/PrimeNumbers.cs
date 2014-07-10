using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            int[] arr = new int[n - 1];
            bool[] primeNumbers = new bool[n - 1];

            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = true;
            }

            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i - 1] = i + 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] % arr[i] == 0)
                    {
                        primeNumbers[k] = false;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (primeNumbers[i] == true)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}

