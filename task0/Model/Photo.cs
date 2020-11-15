using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    sealed class Photo:Media
    {
        public string Permission { get; private set; }
        private Photo(string name, string path,double volume, string permission )
            : base(name, path, volume)
        {
            Permission = permission;            
        }
    }
}
