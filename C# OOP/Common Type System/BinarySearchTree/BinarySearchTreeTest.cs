using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /*
     * Define the data structure binary search tree with operations for "adding new element",
     * "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
     * Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode()
     * and the operators for comparison  == and !=. Add and implement the ICloneable interface
     * for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the tree)
     * and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.

     */

    class BinarySearchTreeTest
    {
        static void Main()
        {
            BinarySearchTree<int> tree1 =

                new BinarySearchTree<int>(5,
                    new BinarySearchTree<int>(2,
                        new BinarySearchTree<int>(-4),
                        new BinarySearchTree<int>(3)),
                    new BinarySearchTree<int>(12,
                        new BinarySearchTree<int>(9),
                        new BinarySearchTree<int>(21,
                            new BinarySearchTree<int>(19),
                            new BinarySearchTree<int>(25))));

            //tree.DeleteNode(12);
            Console.WriteLine(tree1.ToString());

            BinarySearchTree<int> tree2 =

                new BinarySearchTree<int>(5,
                    new BinarySearchTree<int>(2,
                        new BinarySearchTree<int>(-4),
                        new BinarySearchTree<int>(3)),
                    new BinarySearchTree<int>(12,
                        new BinarySearchTree<int>(9),
                        new BinarySearchTree<int>(21,
                            new BinarySearchTree<int>(19),
                            new BinarySearchTree<int>(25))));

        }
    }
}
