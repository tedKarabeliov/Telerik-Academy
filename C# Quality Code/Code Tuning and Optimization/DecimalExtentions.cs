using System;
using System.Collections.Generic;

namespace CodeTuningandOptimization
{
    static class DecimalExtentions
    {
        public static void Add(decimal start, decimal end)
        {
            for (decimal i = start; i < end; i++)
            {
            }
        }

        public static void Substract(decimal start, decimal end)
        {
            for (decimal i = end; i >= start; i--)
            {
            }
        }

        public static void Multiply(decimal start, decimal end)
        {
            for (decimal i = start; i < end; i *= 2)
            {
            }
        }

        public static void Divide(decimal start, decimal end)
        {
            for (decimal i = end; i >= start; i /= 2)
            {
            }
        }

        public static void SquareRoot(decimal start, decimal end)
        {
            for (double i = (double)end; i >= (double)start; i = Math.Sqrt((double)i))
            {
            }
        }

        public static void Logarithm(decimal start, decimal end)
        {
            for (double i = (double)end; i >= (double)start; i = Math.Log10((double)i))
            {
            }
        }

        public static void Sinus(decimal start, decimal end)
        {
            for (double i = (double)end; i >= (double)start; i = Math.Sin((double)i))
            {
            }
        }
    }
}
