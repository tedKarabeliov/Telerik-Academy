using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Float
{
    static void Main()
    {
        Console.WriteLine("Enter floating point number:");
        float x = float.Parse(Console.ReadLine());
        byte[] arr = BitConverter.GetBytes(x);

        int[] man1 = new int[8];
        int[] man2 = new int[8];
        int[] man3 = new int[7];
        int[] exp = new int[8];

        int ost = 0;
        for (int i = 0; arr[0] != 0 && i < 8; i++)
        {
            ost = arr[0] % 2;
            man1[i] = ost;
            arr[0] /= 2;
        }
        for (int i = 0; arr[1] != 0 && i < 8; i++)
        {
            ost = arr[1] % 2;
            man2[i] = ost;
            arr[1] /= 2;
        }
        for (int i = 0; arr[2] != 0 && i < 7; i++)
        {
            ost = arr[2] % 2;
            man3[i] = ost;
            arr[2] /= 2;
        }
        ost = arr[2] % 2;
        exp[0] = ost;
        for (int i = 1; arr[3] != 0 && i < 8; i++)
        {
            ost = arr[3] % 2;
            exp[i] = ost;
            arr[3] /= 2;
        }
        int sign = arr[3];

        Console.WriteLine("Sign = " + sign);

        Console.Write("Exponenta = ");
        for (int i = exp.Length - 1; i >= 0; i--)
        {
            Console.Write(exp[i]);
        }
        Console.WriteLine();

        Console.Write("Mantissa = ");
        for (int i = man3.Length - 1; i >= 0; i--)
        {
            Console.Write(man3[i]);
        }
        for (int i = man2.Length - 1; i >= 0; i--)
        {
            Console.Write(man2[i]);
        }
        for (int i = man1.Length - 1; i >= 0; i--)
        {
            Console.Write(man1[i]);
        }
        Console.WriteLine();

        

       
    }
}

