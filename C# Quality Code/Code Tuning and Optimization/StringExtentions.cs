using System;

namespace CodeTuningandOptimization
{
    public static class StringExtentions
    {
        public static string[] InsertionSort(string[] arr)
        {
            int i, j;

            for (i = 1; i < arr.Length; i++)
            {
                string value = arr[i];
                j = i - 1;
                while ((j >= 0) && (arr[j].CompareTo(value) > 0))
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
            }
            return arr;
        }

        public static string[] SelectionSort(string[] arr)
        {
            int i, j;
            int min;
            string temp;

            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
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

        public static string[] Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string pivot = elements[(left + right) / 2];

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
                    string tmp = elements[i];
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
