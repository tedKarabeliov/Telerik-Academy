using System;
using System.Collections.Generic;

namespace ReadTree
{
    public static class TreeUtilsInt
    {
        public static List<TreePath<int>> FindAllPathsWithGivenSum(TreeNode<int> node, int sum)
        {
            var foundPaths = new List<TreePath<int>>();
            var currentSum = 0;
            FindAllPathsWithGivenSumDFS(node, currentSum, sum, foundPaths);
            return foundPaths;
        }

        public static List<TreeNode<int>> FindSubtreesWithGivenSum(Tree<int> tree, int targetSum)
        {
            List<TreeNode<int>> foundTrees = new List<TreeNode<int>>();
            TraverseDFS(tree.Root, targetSum, foundTrees);
            return foundTrees;
        }

        private static void TraverseDFS(TreeNode<int> node, int targetSum, List<TreeNode<int>> foundTrees)
        {
            var children = node.GetChildren();
            foreach (var child in children)
            {
                var currentSum = FindSubtreesWithGivenSumBFS(child, targetSum);
                TraverseDFS(child, targetSum, foundTrees);
                if (currentSum == targetSum)
                {
                    foundTrees.Add(child);
                }
            }

        }

        private static int FindSubtreesWithGivenSumBFS(TreeNode<int> node, int targetSum)
        {
            int sum = 0;

            Queue<TreeNode<int>> BFSQueue = new Queue<TreeNode<int>>();
            BFSQueue.Enqueue(node);

            while (BFSQueue.Count != 0)
            {
                var currentNode = BFSQueue.Dequeue();
                sum += currentNode.Value;

                var currentNodeChildren = currentNode.GetChildren();
                foreach (var child in currentNodeChildren)
                {
                    BFSQueue.Enqueue(child);
                }
            }

            return sum;
        }

        private static void FindAllPathsWithGivenSumDFS(
            TreeNode<int> node, int currentSum, int targetSum, List<TreePath<int>> foundPaths)
        {
            currentSum += node.Value;
            if (targetSum == node.Value)
            {
                var newPath = new TreePath<int>();
                newPath.Add(node);
                foundPaths.Add(newPath);
            }
            else if (currentSum == targetSum)
            {
                var newPath = new TreePath<int>();
                for (TreeNode<int> currentNode = node; currentNode != null; currentNode = currentNode.Parent)
                {
                    newPath.Add(currentNode);
                }
                foundPaths.Add(newPath);
            }

            var children = node.GetChildren();
            foreach (var child in children)
            {
                FindAllPathsWithGivenSumDFS(child, currentSum, targetSum, foundPaths);
            }
        }
    }
}
