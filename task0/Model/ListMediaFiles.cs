using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace task0
{
    class ListMediaFiles
    {
        public ListMediaFiles()
        {
            MediaFiles = new ObservableCollection<Media>();
        }

        public ObservableCollection<Media> MediaFiles { get; private set; }
        //public ObservableCollection<Media> MediaFiles
        //{
        //    get
        //    {
        //        return _mediaFiles;
        //    }
        //    set
        //    {
        //        _mediaFiles = value;

        //        OnPropertyChanged("MediaFiles");
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


    }
}
