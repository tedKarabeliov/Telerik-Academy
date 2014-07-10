using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Neighbors
{
    static string ComparePrevous(int[] arr, int l, int n)
    {
        string result;
        if (arr[n] > arr[n - 1])
        {
            result = "is bigger than";
        }
        else if (arr[n] < arr[n - 1])
        {
            result = "is smaller than";
        }
        else
        {
            result = "is equal to";
        }
        return result;
    }
    static string CompareNext(int[] arr, int l, int n)
    {
        string result;
        if (arr[n] > arr[n + 1])
        {
            result = "is bigger than";
        }
        else if (arr[n] < arr[n + 1])
        {
            result = "is smaller than";
        }
        else
        {
            result = "is equal to";
        }
        return result;

    }
    static void Main()
    {
        int[] arr = { 7, 3, 5, 1, 8, 7, 6, 9, 2, 54, 6, 5, 3, 5, 67, 3, 54, 67, };
        int l = arr.Length - 1;
        Console.WriteLine("Current array: ");
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine("\nEnter index of the number from array: ");
        int n = int.Parse(Console.ReadLine());
        if (n > l || n < 0)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        if (n == 0)
        {
            Console.Write("Number " + arr[n] + " " +
            CompareNext(arr, arr.Length - 1, n) + " " + arr[n + 1]);
        }
        else if (n == arr.Length - 1)
        {
            Console.Write("Number " + arr[n] + " " +
            ComparePrevous(arr, l, n) + " " + arr[n - 1]);
        }
        else
        {
            Console.Write("Number " + arr[n] + " " +
            ComparePrevous(arr, l, n) + " " + arr[n - 1] +
            " and " + CompareNext(arr, l, n) + " " + arr[n + 1]);
        }
        Console.WriteLine();

    }
}

