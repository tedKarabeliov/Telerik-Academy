using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Varaibles__Data_Expressions_and_Constants
{
    class Program
    {
        public void PrintStatistics(double[] statistics, int arrLength)
        {
            double max = double.MinValue;
            for (int i = 0; i < arrLength; i++)
            {
                if (statistics[i] > max)
                {
                    max = statistics[i];
                }
            }
            PrintMax(max);
            double min = double.MaxValue;
            for (int i = 0; i < arrLength; i++)
            {
                if (statistics[i] < min)
                {
                    min = statistics[i];
                }
            }
            PrintMin(min);

            double sum = 0;
            for (int i = 0; i < arrLength; i++)
            {
                sum += statistics[i];
            }
            PrintAverage(sum / arrLength);
        }
    }
}
