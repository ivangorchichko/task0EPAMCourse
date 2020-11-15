using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Photo:Media, IOperationsViewing
    {
        public string Permission { get; private set; }
        private Photo(string name, string path,double volume, string permission )
            : base(name, path, volume)
        {
            Permission = permission;            
        }
        public void Next()
        {

        }
        public void Previous()
        {

        }
    }
}
