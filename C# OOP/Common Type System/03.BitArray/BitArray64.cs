using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        private int[] bitArray;
        public BitArray64(ulong var)
        {
            bitArray = new int[64];
            int currentIndex = 63;
            while (var != 0)
            {
                bitArray[currentIndex] = (int)(var % 2);
                var /= 2;
                currentIndex--;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= 63)
                {
                    return this.bitArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index must be between 0 and 63");
                }
            }
            set
            {
                if (index >= 0 && index <= 63)
                {
                    this.bitArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index must be between 0 and 63");
                }
            }
        }

        public static bool operator ==(BitArray64 arr1, BitArray64 arr2)
        {
            return arr1.Equals(arr2);
        }
        public static bool operator !=(BitArray64 arr1, BitArray64 arr2)
        {
            return !(arr1.Equals(arr2));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int[] GetBitArray()
        {
            return this.bitArray;
        }

        public override bool Equals(object obj)
        {
            int[] arr = (obj as BitArray64).GetBitArray();
            for (int i = 0; i < 64; i++)
            {
                if (this.bitArray[i] == arr[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("GetHashCode expanded");
            return base.GetHashCode();
        }

    }
}
