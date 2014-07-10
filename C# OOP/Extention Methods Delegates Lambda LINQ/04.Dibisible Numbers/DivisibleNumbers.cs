using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

//6. Write a program that prints from given array of
//integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions.
//Rewrite the same with LINQ.

namespace Divisible_Numbers
{
    class DivisibleNumbers
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 21, 24, 26, 105, 106 };

            var result =
                numbers.Where(number => number % 21 == 0);

            Console.WriteLine("Result with lambda expressions:");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            List<int> numbersLINQ = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 21, 24, 26, 105, 106 };

            var resultLINQ =
                from number in numbers
                where number % 21 == 0
                select number;

            Console.WriteLine("Result with LINQ:");
            foreach (var number in resultLINQ)
            {
                Console.WriteLine(number);
            }

        }
    }
}
