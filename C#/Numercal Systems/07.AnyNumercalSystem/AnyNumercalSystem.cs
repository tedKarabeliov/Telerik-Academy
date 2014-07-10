using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class AnyNumercalSystem
{
    static void BinaryToDecimal(string x)
    {
        int ost = 0;
        int sum = 0;
        int power = -1;
        for (int i = x.Length - 1; i > -1; i--)
        {
            if (x[i] != '0' && x[i] != '1')
            {
                return;
            }
            power++;
            ost = (x[i] - '0') % 10;
            sum += ost * (int)Math.Pow(2, power);
        }
        Console.WriteLine(sum);
    }
    static void DecimalToBinary(int x)
    {
        if (x == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] result = new int[32]; ;
            for (int i = 0; i < 32; i++)
            {
                result[i] = 2;
            }
            for (int i = 31; x != 0; i--)
            {
                result[i] = x % 2;
                x /= 2;
            }
            for (int i = 0; i < 32; i++)
            {
                while (result[i] != 2)
                {
                    Console.Write(result[i]);
                    i++;
                    if (i == 32)
                    {
                        i = 32;
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
    static void DecimalToHexademical(int x)
    {
        if (x == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int[] result = new int[10];
            int ost = 0;
            for (int i = 9; i > -1; i--)
            {
                while (x != 0)
                {
                    ost = x % 16;
                    result[i] = ost;
                    x /= 16;
                    i--;
                    if (x == 0)
                    {
                        i = -1;
                        break;
                    }
                }
                for (int k = 0; k < 10; k++)
                {
                    if (result[k] != 0)
                    {
                        while (k < 10)
                        {
                            switch (result[k])
                            {
                                case 10: Console.Write('A'); break;
                                case 11: Console.Write('B'); break;
                                case 12: Console.Write('C'); break;
                                case 13: Console.Write('D'); break;
                                case 14: Console.Write('E'); break;
                                case 15: Console.Write('F'); break;
                                default: Console.Write(result[k]); break;
                            }
                            k++;
                        }
                    }
                }
            }
        }
    }
    static void HexademicalToDecimal(string x)
    {
        x = x.ToLower();

        int ost = 0;
        int sum = 0;
        int power = -1;
        int number = 0;
        for (int i = x.Length - 1; i > -1; i--)
        {
            switch (x[i])
            {
                case 'a': number = 10; break;
                case 'b': number = 11; break;
                case 'c': number = 12; break;
                case 'd': number = 13; break;
                case 'e': number = 14; break;
                case 'f': number = 15; break;
                default: number = x[i]; break;
            }

            power++;
            ost = number % 16;
            sum += ost * (int)Math.Pow(16, power);
        }
        Console.WriteLine(sum);
    }
    static void BinaryToHexademical(string x)
    {
        if (x == "0")
        {
            Console.WriteLine(0);
        }
        else
        {

            int[] binary = { 0, 1, 10, 11, 100, 101, 110, 111, 1000, 1001, 1010, 1011, 1100, 1101, 1110, 1111 };
            string[] hexademical = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string[] result = new string[20];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = "*";
            }

            string number = null;
            int resultindex = -1;
            for (int i = x.Length - 1; i > -1; )
            {
                if (i < 4)
                {
                    int k = 0;
                    while (k <= i)
                    {
                        number += x[k];
                        k++;
                    }
                }
                else
                {
                    for (int k = i - 3; k < x.Length && k <= i; k++)
                    {
                        number += x[k];
                    }
                }

                for (int k = 0; k < 16; k++)
                {
                    if (Convert.ToInt32(number) == binary[k])
                    {
                        resultindex++;
                        result[resultindex] = hexademical[k];
                        number = "";
                        break;
                    }
                }
                i -= 4;
            }

            for (int i = 19; i > -1; i--)
            {
                if (result[i] != "*")
                {
                    while (i > -1)
                    {
                        Console.Write(result[i]);
                        i--;
                    }
                }
            }
        }
    }
    static void HexademicalToBinary(string x)
    {
        x = x.ToLower();
        char[] hexademical = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        string[] binary = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };

        for (int i = 0; i < x.Length; i++)
        {
            for (int k = 0; k < 16; k++)
            {
                if (x[i] == hexademical[k])
                {
                    if (i == 0)
                    {
                        Console.Write(binary[k]);
                    }
                    else
                    {
                        Console.Write(binary[k]);
                    }
                    break;
                }
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number:");
        string X = Console.ReadLine();
        Console.WriteLine("Enter numeral system which will be converted from:");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numeral system which will be converted to:");
        int d = int.Parse(Console.ReadLine());
        

        if (s == 2 && d == 10)
        {
            BinaryToDecimal(X);
        }
        else if (s == 10 && d == 2)
        {
            DecimalToBinary(Convert.ToInt32(X));
        }
        else if (s == 10 && d == 16)
        {
            DecimalToHexademical(Convert.ToInt32(X));
        }
        else if (s == 16 && d == 10)
        {
            HexademicalToDecimal(X);
        }
        else if (s == 2 && d == 16)
        {
            BinaryToHexademical(X);
        }
        else if (s == 16 && d == 2)
        {
            HexademicalToBinary(X);
        }
        Console.WriteLine();
    }
}

