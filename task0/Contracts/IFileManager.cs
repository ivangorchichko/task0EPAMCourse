using System;
using System.Collections.Generic;
using System.Text;

namespace task0.IService
{
    interface IFileManager
    {
        void OpenFile(Media media);
        void SavePlayList(Media media);
        void OpenPlayList(Media media);
    }
}
