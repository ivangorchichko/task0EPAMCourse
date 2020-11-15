using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    public abstract class Media : IMedia
    {   
        public string Name { get; private set; }
        public string Path { get; private set; }
        public double Volume { get; private set; }

        protected Media(string name, string path, double volume)
        {
            Name = name;
            Path = path;
            Volume = volume;
        }
        public void OpenFile(Media media)
        {

        }

        public void DeleteFile(Media media)
        {
            
        }
    }
}
