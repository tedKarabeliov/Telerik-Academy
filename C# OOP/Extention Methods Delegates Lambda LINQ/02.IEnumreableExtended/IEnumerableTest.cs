using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Implement a set of extension methods for IEnumerable<T>
//that implement the following group functions: sum, product,
//min, max, average.

namespace IEnumerable
{
    class IEnumerableTest
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);
            int sum = list.Sum();
            int product = list.Product();
            int min = list.Min();
            int max = list.Max();
            int average = list.Average();
        }
    }
}
