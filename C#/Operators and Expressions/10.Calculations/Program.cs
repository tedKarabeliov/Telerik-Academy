using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    private static string ShowResult(List<string> list)
    {
        string result = null;
        for (int i = 0; i < list.Count; i++)
        {
            result += list[i];
        }
        return result;
    }
    static int SumDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    static string ReverseDigits(int number)
    {
        int rest = 0;
        List<string> list = new List<string>();
        while (number != 0)
        {
            rest = number % 10;
            list.Add(rest.ToString());
            number /= 10;
        }
        return ShowResult(list);
        
    }
    static string LastDigitFirst(int number)
    {
        int rest = 0;
        List<string> list = new List<string>();
        while (number != 0)
        {
            rest = number % 10;
            list.Add(rest.ToString());
            number /= 10;
        }
        list.Reverse();

        //switch last with first
        string memory = null;
        memory = list[list.Count - 1];
        list.Insert(0, memory);
        list.RemoveAt(list.Count - 1);

        return ShowResult(list);
    }
    static string SecondDigitThird(int number)
    {
        int rest = 0;
        List<string> list = new List<string>();
        while (number != 0)
        {
            rest = number % 10;
            list.Add(rest.ToString());
            number /= 10;
        }
        list.Reverse();

        //switch second with third
        string memory = null;
        memory = list[1];
        list[1] = list[2];
        list[2] = memory;

        return ShowResult(list);
    }

    static void Main()
    {
        Console.WriteLine("Enter a 4 digit number:");
        int number = int.Parse(Console.ReadLine());
        if (number < 1000 || number > 9999)
        {
            throw new ArgumentException("Number must be 4 digits!");
        }
        Console.WriteLine("Sum of the digits if the number: " + SumDigits(number));
        Console.WriteLine("Reversed number: " + ReverseDigits(number));
        Console.WriteLine("Last digit flipped with first: " + LastDigitFirst(number));
        Console.WriteLine("Second digit flipped with third: " + SecondDigitThird(number));
    }
}

