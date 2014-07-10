using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class EqualArrays
{
    static void Main()
    {
        Console.WriteLine("Enter elements of the first array separated with interval:");
        string[] arr1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Enter elements of the first array separated with interval:");
        string[] arr2 = Console.ReadLine().Split(' ');
        Console.Write("Do bot arrays match? --> ");
        bool isMatch = true;
        if (arr1.Length != arr2.Length)
        {
            isMatch = false;
        }
        else
        {
            int i1 = 0;
            int i2 = 0;
            while (isMatch && i1 < arr1.Length)
            {
                isMatch = arr1[i1] == arr2[i2];
                i1++;
                i2++;
            }
            Console.Write(isMatch + "\n");
            
        }

    }
}

