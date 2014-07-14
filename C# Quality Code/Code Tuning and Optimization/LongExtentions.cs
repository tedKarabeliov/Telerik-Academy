using System;
using System.Collections.Generic;

namespace CodeTuningandOptimization
{
    static class LongExtentions
    {
        public static void Add(long start, long end)
        {
            for (long i = start; i < end; i++)
            {
            }
        }

        public static void Substract(long start, long end)
        {
            for (long i = end; i >= start; i--)
            {
            }
        }

        public static void Multiply(long start, long end)
        {
            for (long i = start; i < end; i *= 2)
            {
            }
        }

        public static void Divide(long start, long end)
        {
            for (long i = end; i >= start; i /= 2)
            {
            }
        }
    }
}
