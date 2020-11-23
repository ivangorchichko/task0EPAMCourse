using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using task0.Contracts;

namespace task0.Service
{
    public class FileManager : IFileManager
    {
        public FileManager()
        {
           
        }
        public Media OpenFile(string path)
        {
            File.Open(path, FileMode.Open);
            return null;
        }
        public void DeleteFile(string path)
        {

        }
        public void RenameFile(string path, string newName)
        {
          
        }

        
    }
}
