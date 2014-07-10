using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IEnumerable
{
    public static class IEnumerableExtentions
    {
        public static T Sum<T> (this IEnumerable<T> elements)
        {
            try
            {
                dynamic sum = default(T);
                foreach (dynamic element in elements)
                {
                    sum += element;
                }
                return sum;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                return default(T);
            }
        }

        public static T Product<T>(this IEnumerable<T> elements)
        {
            try
            {
                dynamic product = 1;

                foreach (dynamic element in elements)
                {
                    product *= element;
                }
                return product;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                return default(T);
            }
        }

        public static T Min<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            try
            {
                dynamic min = elements.First();
                foreach (dynamic element in elements)
                {
                    if (element < min)
                    {
                        min = element;
                    }
                }
                return min;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Collection must not be empty");
                return default(T);
            }
        }

        public static T Max<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            try
            {
                dynamic max = elements.First();
                foreach (dynamic element in elements)
                {
                    if (element > max)
                    {
                        max = element;
                    }
                }
                return max;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Collection must not be empty");
                return default(T);
            }
        }

        public static T Average<T>(this IEnumerable<T> elements)
        {
            try
            {
                dynamic sum = default(T);
                int count = 0;

                foreach (dynamic element in elements)
                {
                    sum += element;
                    count++;
                }
                return sum / count;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                return default(T);
            }
        }
    }
}
