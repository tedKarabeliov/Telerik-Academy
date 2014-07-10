using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ReadNumber
{
    static void RandomNumber(List<int> numbers, Random rgen, int start, int end)
    {
        int randomnumber = rgen.Next(start, end + 1);
        if (numbers.Count == 10)
        {
            return;
        }
        if (randomnumber < 0 || randomnumber > 100)
        {
            throw new ArgumentOutOfRangeException("randomnumber", "Number succeeded 100 or is below 0");
        }
        numbers.Add(randomnumber);
        RandomNumber(numbers, rgen, start, end);
    }
    static void SortNumbers(List<int> numbers)
    {
        numbers.Sort();
    }

    static void Main()
    {
        Console.WriteLine("Numbers must be between 0 and 100!");
        Console.Write("Enter \"start\" number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter \"end\" number: ");
        int end = int.Parse(Console.ReadLine());
        Random rgen = new Random();
        List<int> numbers = new List<int>();
        RandomNumber(numbers, rgen, start, end);
        SortNumbers(numbers);
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

