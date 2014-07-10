using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadTree
{
    public static class TreeUtils<T>
    {
        private static int FindLongestPathDFS(TreeNode<T> node, int pathCount, ref int maxPath)
        {
            var children = node.GetChildren();
            foreach (var child in children)
            {
                pathCount = FindLongestPathDFS(child, ++pathCount, ref maxPath);
            }
            if (pathCount > maxPath)
            {
                maxPath = pathCount;
            }
            return --pathCount;
        }

        private static void BFS(TreeNode<T> node)
        {
            Queue<TreeNode<T>> BFSQueue = new Queue<TreeNode<T>>();

            BFSQueue.Enqueue(node);
            while (BFSQueue.Count != 0)
            {
                var currentNode = BFSQueue.Dequeue();
                var currentNodeChildren = currentNode.GetChildren();
                foreach (var child in currentNodeChildren)
                {
                    BFSQueue.Enqueue(child);
                }
            }
        }

        public static TreeNode<T> FindRootNode(Tree<T> tree)
        {
            var root = tree.Root;
            return root;
        }

        public static List<TreeNode<T>> FindAllLeafNodes(Tree<T> tree)
        {
            List<TreeNode<T>> leafNodes = new List<TreeNode<T>>();
            Queue<TreeNode<T>> BFSQueue = new Queue<TreeNode<T>>();

            BFSQueue.Enqueue(tree.Root);
            while (BFSQueue.Count != 0)
            {
                var currentNode = BFSQueue.Dequeue();

                if (currentNode.GetChildren().Count == 0)
                {
                    leafNodes.Add(currentNode);
                }

                var currentNodeChildren = currentNode.GetChildren();
                foreach (var child in currentNodeChildren)
                {
                    BFSQueue.Enqueue(child);
                }
            }

            return leafNodes;
        }

        public static List<TreeNode<T>> FindAllMiddleNodes(Tree<T> tree)
        {
            List<TreeNode<T>> middleNodes = new List<TreeNode<T>>();
            Queue<TreeNode<T>> BFSQueue = new Queue<TreeNode<T>>();

            BFSQueue.Enqueue(tree.Root);
            while (BFSQueue.Count != 0)
            {
                var currentNode = BFSQueue.Dequeue();

                if (!(currentNode.GetChildren().Count == 0))
                {
                    middleNodes.Add(currentNode);
                }

                var currentNodeChildren = currentNode.GetChildren();
                foreach (var child in currentNodeChildren)
                {
                    BFSQueue.Enqueue(child);
                }
            }

            return middleNodes;
        }

        public static int FindLongestPath(Tree<T> tree)
        {
            var root = tree.Root;
            var pathCount = 1;
            var maxPath = 1;
            FindLongestPathDFS(root, pathCount, ref maxPath);
            return maxPath;
        }
    }
}
