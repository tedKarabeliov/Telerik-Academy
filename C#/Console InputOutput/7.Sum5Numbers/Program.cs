using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        int number = 0;
        int sum = 0;
        bool IsSuccess;
        for (int i = 1; i <= 5; i++)
        {
            IsSuccess = int.TryParse(Console.ReadLine(),out number);
            while (!IsSuccess)
            {
                Console.WriteLine("Invalid number.Try again:");
                IsSuccess = int.TryParse(Console.ReadLine(), out number);
            }
            sum += number;
        }
        Console.WriteLine("Sum of numbers = " + sum);
    }
}

