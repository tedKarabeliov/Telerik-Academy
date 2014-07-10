using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        public TreeNode<T> Root { get; set; }

        public BinarySearchTree(T value)
        {
            this.Root = new TreeNode<T>(value);
        }

        public BinarySearchTree(T value, params BinarySearchTree<T>[] children)
            : this(value)
        {
            foreach (BinarySearchTree<T> child in children)
            {
                this.Root.AddChild(child.Root);
            }
        }

        public void Add(T value)
        {
            TreeNode<T> node = new TreeNode<T>(value);
            this.Root.AddChild(node);
        }

        public TreeNode<T> Search(T value)
        {
            return SearchNode(this.Root, value);
        }

        private TreeNode<T> SearchNode(TreeNode<T> currentNode, T value)
        {
            TreeNode<T> searchNode = new TreeNode<T>(value);

            if (currentNode == null)
            {
                return null;
            }

            int comparer = currentNode.Value.CompareTo(searchNode.Value);
            if (comparer == 0)
            {
                return currentNode;
            }
            else if (comparer > 0)
            {
                return SearchNode(currentNode.LeftChild, value);
            }
            else
            {
                return SearchNode(currentNode.RightChild, value);
            }
        }

        public void DeleteNode(T value)
        {
            TreeNode<T> node = SearchNode(this.Root, value);
            if (node != null)
            {
                node.Delete();
            }
            else
            {
                throw new InvalidOperationException();
            }

        }

        public override string ToString()
        {
            return TraverseBFS(this.Root);
        }

        private string TraverseBFS(TreeNode<T> root, string str = "", string spaces = "")
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            if (root != null)
            {
                queue.Enqueue(root);
                while (true)
                {
                    foreach (var item in queue)
                    {
                        str += item.Value + " ";
                    }
                    str = str.Remove(str.Length - 1, 1);

                    List<TreeNode<T>> temp = new List<TreeNode<T>>();
                    while (queue.Count != 0)
                    {
                        temp.Add(queue.Dequeue());
                    }

                    foreach (var node in temp)
                    {
                        if (node.LeftChild != null)
                        {
                            queue.Enqueue(node.LeftChild);
                        }
                        if (node.RightChild != null)
                        {
                            queue.Enqueue(node.RightChild);
                        }
                    }
                    if (queue.Count == 0)
                    {
                        break;
                    }
                    str += "\n";
                    spaces += "  ";
                    str += spaces;
                }
            }
            return str;
        }

        public override bool Equals(object obj)
        {
            if (this.TraverseBFS(this.Root) == (obj as BinarySearchTree<T>).TraverseBFS((obj as BinarySearchTree<T>).Root))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(BinarySearchTree<T> tree1, BinarySearchTree<T> tree2)
        {
            return tree1.Equals(tree2);
        }
        public static bool operator !=(BinarySearchTree<T> tree1, BinarySearchTree<T> tree2)
        {
            return !(tree1.Equals(tree2));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 3;
        }
    }
}
