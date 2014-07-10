using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Write a generic class GenericList<T> that keeps a list
//of elements of some parametric type T. Keep the elements
//of the list in an array with fixed capacity which is
//given as parameter in the class constructor. Implement methods
//for adding element, accessing element by index, removing
//element by index, inserting element at given position,
//clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

//6. Implement auto-grow functionality: when the internal array is full,
//create a new array of double size and move all elements to it.

//7. Create generic methods Min<T>() and Max<T>() for finding the minimal and
//maximal element in the  GenericList<T>. You may need to add a generic
//constraints for the type T.


namespace Generic_List
{
    class GenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(2);
            for (int i = 0; i < 6; i++)
            {
                list.Add(i + 1);
            }

            list.Remove(2);
            list.Remove(1);
            int count = list.Count;
            list.Insert(2, 3);
            list.Insert(2, 3);
            list.Insert(2, 3);
            list.Insert(2, 3);
            list.Insert(2, 3);
            list.Insert(1, 2);
            count = list.Count;
            int max = list.Max();
            Console.WriteLine(list.ToString());
        }
    }
}
