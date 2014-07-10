using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LastDigit
{
    static string LastNumber(int n)
    {
        n = Math.Abs(n %= 10);
        string number;
        switch (n)
        {
            case 0:
                number = "zero";
                break;
            case 1:
                number = "one";
                break;
            case 2:
                number = "two";
                break;
            case 3:
                number = "three";
                break;
            case 4:
                number = "four";
                break;
            case 5:
                number = "five";
                break;
            case 6:
                number = "six";
                break;
            case 7:
                number = "seven";
                break;
            case 8:
                number = "eight";
                break;
            case 9:
                number = "nine";
                break;
            default:
                return null;
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.Write(LastNumber(n) + "\n");
    }

}

