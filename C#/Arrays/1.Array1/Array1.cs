using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Array1
    {
        static void Main()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }
            foreach (int show in arr)
            {
                Console.Write(show + " ");
            }
            Console.WriteLine();

        }
    }

