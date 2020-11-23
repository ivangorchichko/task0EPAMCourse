using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Audio : Media, ILeafable, IPlayBack
    {
        public byte BitRate { get; set; }
        public TimeSpan Duration { get; set; }

        public Audio(string name, string path, double volume)
            : base(name, path, volume)
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

        public void Next()
        {
            
        }

        public void Previous()
        {
           
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

       
    }
}
