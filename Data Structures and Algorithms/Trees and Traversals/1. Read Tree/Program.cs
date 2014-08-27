using System;
using System.Collections.Generic;

namespace ReadTree
{
    class Program
    {
        static void Main()
        {
            Tree<int> tree =
                new Tree<int>(7,
                    new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                    new Tree<int>(21),
                    new Tree<int>(14,
                        new Tree<int>(23),
                        new Tree<int>(6))
            );

            var root = TreeUtils<int>.FindRootNode(tree);
            var leafNodes = TreeUtils<int>.FindAllLeafNodes(tree);
            var middleNodes = TreeUtils<int>.FindAllMiddleNodes(tree);
            var longestPath = TreeUtils<int>.FindLongestPath(tree);
            var foundPathsWithGivenSum = TreeUtilsInt.FindAllPathsWithGivenSum(tree.Root, 21);
            var foundSubtrees = TreeUtilsInt.FindSubtreesWithGivenSum(tree, 63);
        }
    }
}
