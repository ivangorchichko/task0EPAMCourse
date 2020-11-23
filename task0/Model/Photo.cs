using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Photo:Media, ILeafable
    {

        public string Extention { get; }
        public Photo(string name, string path, double volume)
            : base(name, path, volume)
        {
        }
           
        public void Next()
        {

        }
        public void Previous()
        {

        }

        public override string ShowMediaInfo()
        {
            return "";
        }

        public override bool IsUnique()
        {
            return true;
        }
    }
}
