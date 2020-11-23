using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using task0.Contracts;

namespace task0
{
    class ListMediaFiles 
    {
        private static ObservableCollection<Media> _mediaFiles;
        private ListMediaFiles()
        {
            
        }   
        public static ObservableCollection<Media> GetCollection()
        {
            if(_mediaFiles==null)
            {
                _mediaFiles = new ObservableCollection<Media>();
            }
            return _mediaFiles; 
        }
    }
}
