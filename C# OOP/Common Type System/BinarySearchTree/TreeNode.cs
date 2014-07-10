using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode<T>
         where T : IComparable<T>
    {
        public T Value { get; private set; }
        public TreeNode<T> Parent { get; private set; }
        public TreeNode<T> LeftChild { get; private set; }
        public TreeNode<T> RightChild { get; private set; }

        public TreeNode(T value)
        {
            this.Value = value;
        }

        public void AddChild(TreeNode<T> child)
        {
            if (this.Value.CompareTo(child.Value) >= 0)
            {
                if (this.LeftChild == null)
                {
                    this.LeftChild = child;
                    this.LeftChild.Parent = this;
                }
                else
                {
                    this.LeftChild.AddChild(child);
                }
            }
            else
            {
                if (this.RightChild == null)
                {
                    this.RightChild = child;
                    this.RightChild.Parent = this;
                }
                else
                {
                    this.RightChild.AddChild(child);
                }
            }
        }

        public void Delete()
        {
            if ((this.LeftChild == null) && (this.RightChild == null))
            {
                this.DeleteWithNoChildren();
            }
            else if ((this.LeftChild != null) && (this.RightChild != null))
            {
                this.DeleteWithTwoChildren();
            }
            else
            {
                this.DeleteWithOneChild();
            }
        }

        private void DeleteWithNoChildren()
        {
            if (this.Value.CompareTo(this.Parent.Value) <= 0)
            {
                this.Parent.LeftChild = null;
            }
            else
            {
                this.Parent.RightChild = null;
            }
        }

        private void DeleteWithTwoChildren()
        {
            TreeNode<T> min = this.FindMinInSubtree(this.RightChild, this.RightChild);
            this.Value = min.Value;
            if (min.Value.CompareTo(min.Parent.Value) < 0)
            {
                min.Parent.LeftChild = null;
            }
            else
            {
                min.Parent.RightChild = null;
            }
        }

        private void DeleteWithOneChild()
        {
            TreeNode<T> child;
            if (this.LeftChild != null)
            {
                child = this.LeftChild;
            }
            else
            {
                child = this.RightChild;
            }

            if (this.Value.CompareTo(this.Parent.Value) <= 0)
            {
                this.Parent.LeftChild = child;
            }
            else
            {
                this.Parent.RightChild = child;
            }
            child.Parent = this.Parent;
        }

        public TreeNode<T> FindMinInSubtree(TreeNode<T> child, TreeNode<T> minNode)
        {
            if (child == null)
            {
                return minNode;
            }
            if (child.Value.CompareTo(minNode.Value) < 0)
            {
                minNode = child;
            }
            minNode = FindMinInSubtree(child.LeftChild, minNode);
            minNode = FindMinInSubtree(child.RightChild, minNode);
            return minNode;
        }

    }
}
