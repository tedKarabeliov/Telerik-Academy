using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CodeTuningandOptimization
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            
            //Add int
            stopWatch.Start();
            IntExtentions.Add(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Add int --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Substract int
            stopWatch.Start();
            IntExtentions.Substract(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Substract int --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Multiply int
            stopWatch.Start();
            IntExtentions.Multiply(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Multiply int --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Divide int
            stopWatch.Start();
            IntExtentions.Divide(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Divide int --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Add long
            stopWatch.Start();
            LongExtentions.Add(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Add long --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Substract long
            stopWatch.Start();
            LongExtentions.Substract(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Substract long --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Multiply long
            stopWatch.Start();
            LongExtentions.Multiply(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Multiply long --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Divide long
            stopWatch.Start();
            LongExtentions.Divide(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Divide long --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Add float
            stopWatch.Start();
            FloatExtentions.Add(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Add float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Substract float
            stopWatch.Start();
            FloatExtentions.Substract(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Substract float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Multiply float
            stopWatch.Start();
            FloatExtentions.Multiply(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Multiply float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Divide float
            stopWatch.Start();
            FloatExtentions.Divide(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Divide float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Add double
            stopWatch.Start();
            DoubleExtentions.Add(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Add double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Substract double
            stopWatch.Start();
            DoubleExtentions.Substract(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Substract double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Multiply double
            stopWatch.Start();
            DoubleExtentions.Multiply(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Multiply double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Divide double
            stopWatch.Start();
            DoubleExtentions.Divide(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Divide double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Add decimal
            stopWatch.Start();
            DecimalExtentions.Add(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Add decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Substract decimal
            stopWatch.Start();
            DecimalExtentions.Substract(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Substract decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Multiply decimal
            stopWatch.Start();
            DecimalExtentions.Multiply(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Multiply decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Divide decimal
            stopWatch.Start();
            DecimalExtentions.Divide(1, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Divide decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Square root float
            stopWatch.Start();
            FloatExtentions.SquareRoot(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Square root float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Square root double
            stopWatch.Start();
            DoubleExtentions.SquareRoot(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Square root double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Square root decimal
            stopWatch.Start();
            DecimalExtentions.SquareRoot(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Square root decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Logarithm float
            stopWatch.Start();
            FloatExtentions.Logarithm(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Logarithm float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Logarithm double
            stopWatch.Start();
            DoubleExtentions.Logarithm(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Logarithm double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Logarithm decimal
            stopWatch.Start();
            DoubleExtentions.Logarithm(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Logarithm decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            //Sinus float
            stopWatch.Start();
            FloatExtentions.Sinus(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Sinus float --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Sinus double
            stopWatch.Start();
            DoubleExtentions.Sinus(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Sinus double --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            //Sinus decimal
            stopWatch.Start();
            DecimalExtentions.Sinus(2, 10000000);
            stopWatch.Stop();
            Console.WriteLine("Sinus decimal --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();

            Console.WriteLine();

            var randomValuesInt = new int[] { 4, 7, 3, 9, 2, 12, 1, 11 };
            var sortedValuesInt = new int[] { 1, 2, 3, 4, 7, 9, 11, 12 };
            var reversedValuesInt = new int[] { 12, 11, 9, 7, 4, 3, 2, 1 };

            var randomValuesDouble = new double[] { 4.2, 7.4, 3.75, 9.8, 2.123, 12.2, 1.8473, 11.5 };
            var sortedValuesDouble = new double[] { 1.8473, 2.123, 3.75, 4.2, 7.4, 9.8, 11.5, 12.2 };
            var reversedValuesDouble = new double[] { 12.2, 11.5, 9.8, 7.4, 4.2, 3.75, 2.123, 1.8473 };

            var randomValuesString = new string[] { "hhh", "bbb", "aaa", "lll", "ccc", "vvv", "ccc", "aaA" };
            var sortedValuesString = new string[] { "aaa", "aaA", "bbb", "ccc", "ccc", "hhh", "lll", "vvv" };
            var reversedValuesString = new string[] { "vvv", "lll", "hhh", "ccc", "ccc", "bbb", "aaA", "aaa" };

            //Insertion sort int
            //Random Values
            stopWatch.Start();
            randomValuesInt = IntExtentions.InsertionSort(randomValuesInt);
            stopWatch.Stop();
            Console.Write("Insertion sort with random integers --> ");
            ArrayUtils<int>.Print(randomValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesInt = IntExtentions.InsertionSort(sortedValuesInt);
            stopWatch.Stop();
            Console.Write("Insertion sort with sorted integers --> ");
            ArrayUtils<int>.Print(sortedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesInt = IntExtentions.InsertionSort(reversedValuesInt);
            stopWatch.Stop();
            Console.Write("Insertion sort with reversed integers --> ");
            ArrayUtils<int>.Print(reversedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Insertion sort double
            //Random values
            stopWatch.Start();
            randomValuesDouble = DoubleExtentions.InsertionSort(randomValuesDouble);
            stopWatch.Stop();
            Console.Write("Insertion sort with random doubles --> ");
            ArrayUtils<double>.Print(randomValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesDouble = DoubleExtentions.InsertionSort(sortedValuesDouble);
            stopWatch.Stop();
            Console.Write("Insertion sort with sorted doubles --> ");
            ArrayUtils<double>.Print(sortedValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesDouble = DoubleExtentions.InsertionSort(reversedValuesDouble);
            stopWatch.Stop();
            Console.Write("Insertion sort with reversed doubles --> ");
            ArrayUtils<double>.Print(reversedValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Insertion sort strings
            //Random values
            stopWatch.Start();
            randomValuesString = StringExtentions.InsertionSort(randomValuesString);
            stopWatch.Stop();
            Console.Write("Insertion sort with random strings --> ");
            ArrayUtils<string>.Print(randomValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesString = StringExtentions.InsertionSort(sortedValuesString);
            stopWatch.Stop();
            Console.Write("Insertion sort with sorted strings --> ");
            ArrayUtils<string>.Print(sortedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesString = StringExtentions.InsertionSort(reversedValuesString);
            stopWatch.Stop();
            Console.Write("Insertion sort with reversed strings --> ");
            ArrayUtils<string>.Print(reversedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Selection sort int
            //Random values
            stopWatch.Start();
            randomValuesInt = IntExtentions.SelectionSort(randomValuesInt);
            stopWatch.Stop();
            Console.Write("Selection sort with random integers --> ");
            ArrayUtils<int>.Print(randomValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesInt = IntExtentions.SelectionSort(sortedValuesInt);
            stopWatch.Stop();
            Console.Write("Selection sort with sorted integers --> ");
            ArrayUtils<int>.Print(sortedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesInt = IntExtentions.SelectionSort(reversedValuesInt);
            stopWatch.Stop();
            Console.Write("Selection sort with reversed integers --> ");
            ArrayUtils<int>.Print(reversedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Selection sort doubles
            //Random values
            stopWatch.Start();
            randomValuesDouble = DoubleExtentions.SelectionSort(randomValuesDouble);
            stopWatch.Stop();
            Console.Write("Selection sort with random doubles --> ");
            ArrayUtils<double>.Print(randomValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesDouble = DoubleExtentions.SelectionSort(sortedValuesDouble);
            stopWatch.Stop();
            Console.Write("Selection sort with sorted doubles --> ");
            ArrayUtils<double>.Print(randomValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesDouble = DoubleExtentions.SelectionSort(reversedValuesDouble);
            stopWatch.Stop();
            Console.Write("Selection sort with reversed doubles --> ");
            ArrayUtils<double>.Print(reversedValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Selection sort strings
            //Random strings
            stopWatch.Start();
            randomValuesString = StringExtentions.SelectionSort(randomValuesString);
            stopWatch.Stop();
            Console.Write("Selection sort with random strings --> ");
            ArrayUtils<string>.Print(randomValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted strings
            stopWatch.Start();
            sortedValuesString = StringExtentions.SelectionSort(sortedValuesString);
            stopWatch.Stop();
            Console.Write("Selection sort with sorted strings --> ");
            ArrayUtils<string>.Print(sortedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed strings
            stopWatch.Start();
            reversedValuesString = StringExtentions.SelectionSort(reversedValuesString);
            stopWatch.Stop();
            Console.Write("Selection sort with reversed strings --> ");
            ArrayUtils<string>.Print(reversedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Quick sort
            //Random int
            stopWatch.Start();
            randomValuesInt = IntExtentions.Quicksort(randomValuesInt, 0, randomValuesInt.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with random integers --> ");
            ArrayUtils<int>.Print(randomValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted int
            stopWatch.Start();
            sortedValuesInt = IntExtentions.Quicksort(sortedValuesInt, 0, sortedValuesInt.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with sorted integers --> ");
            ArrayUtils<int>.Print(sortedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed int
            stopWatch.Start();
            reversedValuesInt = IntExtentions.Quicksort(reversedValuesInt, 0, reversedValuesInt.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with reversed integers --> ");
            ArrayUtils<int>.Print(reversedValuesInt);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Quick sort doubles
            //Random values
            stopWatch.Start();
            randomValuesDouble = DoubleExtentions.Quicksort(randomValuesDouble, 0, randomValuesDouble.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with random doubles --> ");
            ArrayUtils<double>.Print(randomValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesDouble = DoubleExtentions.Quicksort(sortedValuesDouble, 0, sortedValuesDouble.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with sorted doubles --> ");
            ArrayUtils<double>.Print(sortedValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesDouble = DoubleExtentions.Quicksort(reversedValuesDouble, 0, reversedValuesDouble.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with reversed doubles --> ");
            ArrayUtils<double>.Print(reversedValuesDouble);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Quick sort strings
            //Random values
            stopWatch.Start();
            randomValuesString = StringExtentions.Quicksort(randomValuesString, 0, randomValuesString.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with random strings --> ");
            ArrayUtils<string>.Print(randomValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Sorted values
            stopWatch.Start();
            sortedValuesString = StringExtentions.Quicksort(sortedValuesString, 0, sortedValuesString.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with sorted strings --> ");
            ArrayUtils<string>.Print(sortedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();

            //Reversed values
            stopWatch.Start();
            reversedValuesString = StringExtentions.Quicksort(reversedValuesString, 0, reversedValuesString.Length - 1);
            stopWatch.Stop();
            Console.Write("Quick sort with reversed strings --> ");
            ArrayUtils<string>.Print(reversedValuesString);
            Console.WriteLine(" --> " + stopWatch.ElapsedTicks + " ticks");
            stopWatch.Reset();
            Console.WriteLine();
        }
    }
}
