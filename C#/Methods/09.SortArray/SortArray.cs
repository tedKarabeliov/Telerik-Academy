using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SortArray
{
    static void HighestLowestNumberInPartOfArray(List<int> arr, int start, int finish, int highorlow)
    {
        int length = arr.Count;
        for (int i = 0; i < start - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }
        int memorystart = start;
        int memoryfinish = finish;
        List<int> jag = new List<int>();
        for (; start <= finish; finish--)
        {
            int result = 0;
            int maxresult = 0;
            for (; start < finish; start++)
            {
                if (arr[start] > arr[start + 1])
                {
                    result = arr[start];
                    if (result > maxresult)
                    {
                        maxresult = result;
                    }
                }
            }
            if (arr[finish] > maxresult)
            {
                maxresult = arr[finish];
            }
            start = memorystart;
            jag.Add(maxresult);
            arr.Remove(maxresult);
            result = maxresult = 0;
        }
        if (highorlow == 1)
        {
            for (int i = 0; i < jag.Count; i++)
            {
                Console.Write(jag[i] + " ");
            }
        }
        else if (highorlow == 2)
        {
            for (int i = jag.Count - 1; i > -1; i--)
            {
                Console.Write(jag[i] + " ");

            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        finish++;
        for (int i = finish; i < length - jag.Count; i++)
        {
            Console.Write(arr[i] + " ");

        }
    }
    static void Main()
    {
        List<int> arr = new List<int>();
        arr.Add(1);
        arr.Add(5);
        arr.Add(2);
        arr.Add(8);
        arr.Add(13);
        arr.Add(8);
        arr.Add(21);
        arr.Add(4);
        arr.Add(2);
        foreach (int show in arr)
        {
            Console.Write(show + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Enter Start Index:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter End Index:");
        int finish = int.Parse(Console.ReadLine());
        Console.WriteLine("For highest/lowest sort press \"1\" and for lowest/highest press \"2\"");
        int highorlow = int.Parse(Console.ReadLine());
        HighestLowestNumberInPartOfArray(arr, start, finish, highorlow);


    }
}

