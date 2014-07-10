using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter parameters of the a(x^2) + bx + c = 0 equation:\n");
        Console.WriteLine("Enter parameter \"a\"");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter parameter \"b\"");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter parameter \"c\"");
        int c = int.Parse(Console.ReadLine());

        int dis = ((b * b) - 4 * a * c);
        int sqrt = (int)Math.Sqrt(dis);
        int x1 = ((-b + sqrt) / (2 * a));
        int x2 = ((-b - sqrt) / (2 * a));
        Console.WriteLine();

        if (dis < 0)
        {
            Console.WriteLine("No roots");
        }
        else if (x1 == x2)
        {
            Console.WriteLine("Double root = " + x1);
        }
        else
        {
            Console.WriteLine("Roots are : {0} and {1}", x1, x2);
        }
        Console.WriteLine();

    }
}

