using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int check = 8;
        int result = number & check;
        bool IsThirdBit1 = false;
        Console.Write("Is number's third bit \"1\"? ");
        if (result != 0)
        {
            IsThirdBit1 = true;
            Console.Write(IsThirdBit1);
        }
        else
        {
            Console.Write(IsThirdBit1);
        }
        Console.WriteLine();
    }
}

