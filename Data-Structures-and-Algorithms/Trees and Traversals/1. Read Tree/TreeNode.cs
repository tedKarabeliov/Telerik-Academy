using System;
using System.Collections.Generic;

namespace ReadTree
{
    public class TreeNode<T>
    {
        private T value;
        public List<TreeNode<T>> children;
        private TreeNode<T> parent;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public TreeNode<T> Parent
        {
            get { return this.parent; }
            private set { this.parent = value; }
        }

        public bool HasParent
        {
            get { return this.Parent != null; }
        }

        public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            child.Parent = this;
            this.children.Add(child);
        }
        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }

        public List<TreeNode<T>> GetChildren()
        {
            return this.children;
        }

    }
}
