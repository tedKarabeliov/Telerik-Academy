using System;
using System.Collections.Generic;
using System.IO;

namespace FileTree
{
    public class Program
    {
        static void Main()
        {
            var folder = new Folder(@"C://Windows");
            var folderTree = FolderUtils.BuildTree(folder);
            var subTreeSize = FolderUtils.GetSumOfFileSizesInSubtree(folderTree.Root);
        }
    }
}
