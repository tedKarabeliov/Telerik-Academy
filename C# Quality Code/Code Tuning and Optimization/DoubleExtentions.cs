using System;
using System.Collections.Generic;

namespace CodeTuningandOptimization
{
    static class DoubleExtentions
    {
        public static void Add(double start, double end)
        {
            for (double i = start; i < end; i++)
            {
            }
        }

        public static void Substract(double start, double end)
        {
            for (double i = end; i >= start; i--)
            {
            }
        }

        public static void Multiply(double start, double end)
        {
            for (double i = start; i < end; i *= 2)
            {
            }
        }

        public static void Divide(double start, double end)
        {
            for (double i = end; i >= start; i /= 2)
            {
            }
        }

        public static void SquareRoot(double start, double end)
        {
            for (double i = end; i >= start; i = Math.Sqrt(i))
            {
            }
        }

        public static void Logarithm(double start, double end)
        {
            for (double i = end; i >= start; i = Math.Log10(i))
            {
            }
        }

        public static void Sinus(double start, double end)
        {
            for (double i = end; i >= start; i = Math.Sin(i))
            {
            }
        }

        public static double[] InsertionSort(double[] arr)
        {
            int i;
            int j;
            double index;

            for (i = 1; i < arr.Length; i++)
            {
                index = arr[i];
                j = i;

                while ((j > 0) && (arr[j - 1] > index))
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }

                arr[j] = index;
            }
            return arr;
        }

        public static double[] SelectionSort(double[] arr)
        {
            int i, j;
            int min;
            double temp;

            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
            return arr;
        }

        public static double[] Quicksort(double[] elements, int left, int right)
        {
            int i = left, j = right;
            double pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    double tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
            return elements;
        }
    }
}
