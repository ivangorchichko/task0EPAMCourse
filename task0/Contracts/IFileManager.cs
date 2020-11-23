using System;
using System.Collections.Generic;
using System.Text;
using task0.Service;

namespace task0.Contracts
{
    interface IFileManager
    { 
        public Media OpenFile(string path);
        public void DeleteFile(string path);
        public void RenameFile(string path, string newName);
    }
}
