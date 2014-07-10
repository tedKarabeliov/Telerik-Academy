using System;
using System.Collections.Generic;

namespace ReadTree
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public Tree(T value)
        {
            this.root = new TreeNode<T>(value);
        }

        public TreeNode<T> Root
        {
            get { return this.root; }
        }
    }
}
