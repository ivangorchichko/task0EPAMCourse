using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using task0.Contracts;

namespace task0
{
    class ListMediaFiles : ISearch
    {
        public ListMediaFiles()
        {
            MediaFiles = new ObservableCollection<Media>();
        }

        public ObservableCollection<Media> MediaFiles { get; private set; }

        public string Search(ObservableCollection<Media> mediaFiles)
        {            
            return null;
        }
    }
}
