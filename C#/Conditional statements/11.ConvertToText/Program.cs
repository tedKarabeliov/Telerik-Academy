using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string[] From0To19 = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                             "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                             "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        int number;
        do
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }
        while (number < 0 || number > 999);

        int firstDigit = number / 100;
        int secondDigit = number / 10;
        int secondDigitHundreds = (number % 100) / 10;
        int secondDigit2 = number % 100;
        int thirdDigit = number % 10;

        if (number >= 0 && number < 20)
        {
            Console.WriteLine(From0To19[number]);
        }
        else if (number > 19 && number < 100)
        {
            if (number % 10 == 0)
            {
                Console.WriteLine(tens[secondDigit - 2]);
            }
            else
            {
                Console.WriteLine(tens[secondDigit - 2] + " " + From0To19[thirdDigit]);
            }
        }
        else if (number > 99 && number < 1000)
        {
            if (secondDigit2 == 0)
            {
                Console.WriteLine(From0To19[firstDigit] + " Hundred");
            }
            else if (secondDigit2 > 0 && secondDigit2 < 20)
            {
                Console.WriteLine(From0To19[firstDigit] + " Hundred " + "and " + From0To19[secondDigit2]);
            }
            else if (thirdDigit == 0)
            {
                Console.WriteLine(From0To19[firstDigit] + " Hundred " + tens[secondDigitHundreds - 2]);
            }
            else
            {
                Console.WriteLine(From0To19[firstDigit] + " Hundred " + tens[secondDigitHundreds - 2] + " " + From0To19[thirdDigit]);
            }
        }
    }
}