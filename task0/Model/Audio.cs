using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    sealed class Audio : Media
    {
        public byte BitRate { get; private set; }
        public DateTime Time { get; private set; }
        private Audio(string name, string path, double volume, byte bitRate, DateTime time)
            : base(name, path, volume)
        {
            BitRate = bitRate;
            Time = time;
        }
    }
}
