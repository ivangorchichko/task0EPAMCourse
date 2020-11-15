using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Video:Media, IOperationsPlayer, IOperationsViewing
    {
        public string Permission { get; private set; }
        public DateTime Time { get; private set; }
        private Video(string name, string path, double volume, string permission, DateTime time)
            : base(name, path, volume)
        {
            Permission = permission;
            Time = time;
        }

        public void Play()
        {
            
        }

        public void Pause()
        {
            
        }

        public void Stop()
        {
            
        }

        public void Next()
        {
            
        }

        public void Previous()
        {
            
        }
    }
}
