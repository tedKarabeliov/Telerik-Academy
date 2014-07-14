using System;
using System.Collections.Generic;

//Write a program that reads N integers from the console and reverses
//them using a stack. Use the Stack<int> class.

class Reverse
{
    private static List<int> ReadInput()
    {
        List<int> list = new List<int>();
        string input = Console.ReadLine();

        while (input != "")
        {
            int currentNumber = int.Parse(input);
            list.Add(currentNumber);
            input = Console.ReadLine();
        }

        return list;
    }

    static void Main()
    {
        List<int> list = ReadInput();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < list.Count; i++)
        {
            stack.Push(list[i]);
        }
        string output = "";
        while (stack.Count != 0)
        {
            output += stack.Pop() + " ";
        }

        Console.WriteLine("Reversed: " + output.Trim());
    }
}
