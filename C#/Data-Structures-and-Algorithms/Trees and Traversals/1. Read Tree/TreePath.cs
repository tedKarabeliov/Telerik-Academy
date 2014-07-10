using System;
using System.Collections.Generic;

namespace ReadTree
{
    public class TreePath<T>
    {
        private List<TreeNode<T>> nodes;

        public TreePath()
            : this(null)
        {
        }

        public TreePath(IEnumerable<TreeNode<T>> nodes)
        {
            this.nodes = new List<TreeNode<T>>();
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    this.nodes.Add(node);
                }
            }
            
        }

        public List<TreeNode<T>> Nodes
        {
            get { return this.nodes; }
        }

        public void Add(TreeNode<T> node)
        {
            this.Nodes.Add(node);
        }
    }
}
