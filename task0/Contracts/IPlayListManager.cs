using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace task0.Contracts
{
    interface IPlayListManager
    {
        void SavePlayList(ObservableCollection<Media> collection);
        void OpenPlayList(string path);
        void DeletePlayList(string path);
        
    }
}
