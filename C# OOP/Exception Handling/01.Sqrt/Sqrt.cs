using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Sqrt
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArithmeticException();
            }
            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }

    }
}

