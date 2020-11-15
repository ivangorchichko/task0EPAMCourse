using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0
{
    sealed class Audio : Media, IOperationsViewing, IOperationsPlayer
    {
        public byte BitRate { get; private set; }
        public DateTime Time { get; private set; }
        private Audio(string name, string path, double volume, byte bitRate, DateTime time)
            : base(name, path, volume)
        {
            BitRate = bitRate;
            Time = time;
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
