using System;
using System.Collections.Generic;
using System.IO;

namespace FileTree
{
    public static class FolderUtils
    {
        public static void TraverseFolder(Folder folder)
        {
            var files = folder.Files;
            if (files != null)
            {
                foreach (var file in files)
                {
                    Console.WriteLine(file.Name);
                }
            }
            
            var childFolders = folder.ChildFolders;
            if (files != null)
            {
                foreach (var f in childFolders)
                {
                    try
                    {
                        TraverseFolder(f);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("File is restricted");
                    }
                }
            }
        }

        public static Tree<Folder> BuildTree(Folder folder)
        {
            var tree = new Tree<Folder>(folder);
            BuildTree(tree.Root);
            return tree;
        }

        public static long GetSumOfFileSizesInSubtree(TreeNode<Folder> node)
        {
            long size = 0;
            GetSumOfFileSizesInSubtree(node, ref size);
            return size;
        }

        private static void BuildTree(TreeNode<Folder> node)
        {
            var childFolders = node.Value.ChildFolders;
            if (childFolders != null)
            {
                foreach (var child in childFolders)
                {
                    var newNode = new TreeNode<Folder>(child);
                    node.AddChild(newNode);
                    BuildTree(newNode);
                }
            }
        }

        private static void GetSumOfFileSizesInSubtree(TreeNode<Folder> node, ref long size)
        {
            var folderFiles = node.Value.Files;
            if (folderFiles != null)
            {
                foreach (var file in folderFiles)
                {
                    size += file.Size;
                }
            }
            

            foreach (var child in node.children)
            {
                GetSumOfFileSizesInSubtree(child, ref size);
            }
        }
    }
}
