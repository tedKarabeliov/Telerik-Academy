using System;
using System.Collections.Generic;
using System.IO;

namespace FileTree
{
    public class Folder
    {
        public string Name { get; set; }

        public File[] Files { get; set; }

        public Folder[] ChildFolders { get; set; }

        public Folder(string name)
        {
            //Assign name
            this.Name = name;

            //Assign files
            try
            {
                var files = Directory.GetFiles(this.Name);
                this.Files = new File[files.Length];
                for (int i = 0; i < files.Length; i++)
                {
                    this.Files[i] = new File(files[i]);
                }


                //Assign folders
                var folders = Directory.GetDirectories(this.Name);
                this.ChildFolders = new Folder[folders.Length];
                for (int i = 0; i < folders.Length; i++)
                {
                    this.ChildFolders[i] = new Folder(folders[i]);
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Restricted file or folder");
            }
        }
    }
}
