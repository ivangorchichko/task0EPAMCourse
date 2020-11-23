using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    public abstract class Media 
    {   
        public string Name { get; }
        public string Path { get; }
        public double Size { get; }

        protected Media(string name, string path, double size)
        {
            Name = name;
            Path = path;
            Size = size;
        }
        public virtual string ShowMediaInfo()
        {
            return "";
        }
        public abstract bool IsUnique();
    }
}
