﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    sealed class Video:Media
    {
        public string Permission { get; private set; }
        public DateTime Time { get; private set; }
        private Video(string name, string path, double volume, string permission, DateTime time)
            : base(name, path, volume)
        {
            Permission = permission;
            Time = time;
        }
    }
}