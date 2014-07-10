using System;
using System.Collections.Generic;

namespace HashTable
{
    class HashTableTest
    {
        static void Main()
        {
            var hashTable = new HashTable<string, int>();
            var keys = hashTable.Keys;

            hashTable["Pesho"] = 5;
            hashTable["Misho"] = 6;
            hashTable["Sasho"] = 7;
            hashTable["Sadsho"] = 7;
            hashTable["Safsho"] = 7;
            hashTable["Sagsho"] = 7;
            hashTable["Sahsho"] = 7;
            hashTable["Sjasho"] = 7;
            hashTable["Skasho"] = 7;
            hashTable["Salsho"] = 7;
            hashTable["Sassho"] = 7;
            hashTable["Saasho"] = 7;
            hashTable["Sasdho"] = 7;
            hashTable["Sfasho"] = 7;
            hashTable["Sagsho"] = 7;
            hashTable["Sasffho"] = 7;
            hashTable["Sashho"] = 7;

            foreach (var item in hashTable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
