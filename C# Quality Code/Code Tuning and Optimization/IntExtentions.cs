using System;
using System.Collections.Generic;

namespace CodeTuningandOptimization
{
    static class IntExtentions
    {
        public static void Add(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
            }
        }

        public static void Substract(int start, int end)
        {
            for (int i = end; i >= start; i--)
            {
            }
        }

        public static void Multiply(int start, int end)
        {
            for (int i = start; i < end; i *= 2)
            {
            }
        }

        public static void Divide(int start, int end)
        {
            for (int i = end; i >= start; i /= 2)
            {
            }
        }

        public static int[] InsertionSort(int[] arr)
        {
            int i;
            int j;
            int index;

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

        public static int[] SelectionSort(int[] arr)
        {
            int i, j;
            int min, temp;

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

        public static int[] Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

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
                    int tmp = elements[i];
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
