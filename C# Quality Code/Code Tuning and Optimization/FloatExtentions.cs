using System;
using System.Collections.Generic;

namespace CodeTuningandOptimization
{
    static class FloatExtentions
    {
        public static void Add(float start, float end)
        {
            for (float i = start; i < end; i++)
            {
            }
        }

        public static void Substract(float start, float end)
        {
            for (float i = end; i >= start; i--)
            {
            }
        }

        public static void Multiply(float start, float end)
        {
            for (float i = start; i < end; i *= 2)
            {
            }
        }

        public static void Divide(float start, float end)
        {
            for (float i = end; i >= start; i /= 2)
            {
            }
        }

        public static void SquareRoot(float start, float end)
        {
            for (double i = end; i >= start; i = Math.Sqrt((float)i))
            {
            }
        }

        public static void Logarithm(float start, float end)
        {
            for (double i = end; i >= start; i = Math.Log10((float)i))
            {
            }
        }

        public static void Sinus(float start, float end)
        {
            for (double i = end; i >= start; i = Math.Sin((float)i))
            {
            }
        }
    }
}
