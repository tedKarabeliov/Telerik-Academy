using System;

namespace CodeTuningandOptimization
{
    public static class ArrayUtils<T>
    {
        public static void Print(T[] arr)
        {
            var printStr = "";
            for (int i = 0; i < arr.Length; i++)
            {
                printStr += arr[i] + " ";
            }
            Console.Write(printStr.TrimEnd());
        }
    }
}
