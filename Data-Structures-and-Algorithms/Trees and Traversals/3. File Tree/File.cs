using System;
using System.Collections.Generic;
using System.IO;

namespace FileTree
{
    public class File
    {
        public string Name { get; set; }
        public long Size { get; private set; }

        public File(string name)
        {
            this.Name = name;
            this.Size = this.GetFileSize();
        }

        private long GetFileSize()
        {
            var size = new FileInfo(this.Name).Length;
            return size;
        }
    }
}
