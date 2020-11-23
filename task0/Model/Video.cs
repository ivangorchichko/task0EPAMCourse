using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Video:Media, IPlayBack, ILeafable
    {
        private const string DefaultCodek = "Mpg"; 
        public string Extention { get; set; }
        public DateTime Time { get; set; }
        
        public Video(string name, string path, double volume)
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
