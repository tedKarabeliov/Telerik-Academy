using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ManyProblems
{
    static int ReversedNumber(int n)
    {
        Console.Write("Reversed number: ");
        int divide;
        for (int i = 0; ; i++)
        {
            divide = n % 10;
            n /= 10;
            Console.Write(divide);
            if (n == 0)
            {
                return n;
            }
        }
    }
    static double Average(int[] arr, int arrlength)
    {
        Console.WriteLine("Enter numbers which will be averaged:");
        double sum = 0;
        for (int i = 0; i < arrlength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        sum /= arrlength;
        return sum;
    }
    static double Equation(double a, double b)
    {
        double x = -b / a;
        return x;
    }

    static void Main()
    {
        Console.WriteLine("Enter \"1\" for reverting a number");
        Console.WriteLine("Enter \"2\" for average");
        Console.WriteLine("Enter \"3\" for resolving a * x + b = 0");
        int choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            Console.WriteLine("Enter positive number for reverting:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ReversedNumber(n);
            Console.WriteLine();
        }
        else if (choose == 2)
        {
            Console.WriteLine("How many numbers will be averaged: \n");
            int arrlength = int.Parse(Console.ReadLine());
            if (arrlength == 0)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            int[] arr = new int[arrlength];
            Console.WriteLine("Average of the numbers is: " + Average(arr, arrlength));
        }
        else if (choose == 3)
        {
            Console.WriteLine("Enter parameter \"a\"");
            double a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("\"a\" must not be 0!");
                return;
            }
            Console.WriteLine("Enter parameter \"b\"");
            double b = int.Parse(Console.ReadLine() + "\n");
            Console.WriteLine("x = " + Equation(a, b));
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

    }
}

