using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Press \"0\" for an integer");
        Console.WriteLine("Press \"1\" for double");
        Console.WriteLine("Press \"2\" for string");
        int choose = int.Parse(Console.ReadLine());

        switch (choose)
        {
            case 0:
            {
                Console.WriteLine("Enter integer:");
                int number0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Result = " + ++number0);
                break;
            }
            case 1:
            {
                Console.WriteLine("Enter double:");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Result = " + ++number1);
                break;
            }
            case 2:
            {
                Console.WriteLine("Enter string:");
                string text = Console.ReadLine();
                Console.WriteLine("Result --> " + text + "*");
                break;
            }
            default: Console.WriteLine("Invalid number!"); break;
        }

    }
}

