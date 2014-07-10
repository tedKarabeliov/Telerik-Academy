using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Define a class BitArray64 to hold 64 bit values inside an ulong value.
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

namespace _03.BitArray
{
    class BitArray64Test
    {
        static void Main()
        {
            ulong var = 56;
            BitArray64 arr1 = new BitArray64(var);
            foreach (var item in arr1)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            BitArray64 arr2 = new BitArray64(56);
            bool eguals = arr1.Equals(arr2);
            bool operatorTest1 = (arr1 == arr2);
            bool operatorTest2 = (arr1 != arr2);
        }
    }
}
