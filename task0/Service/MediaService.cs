using System;
using System.Collections.Generic;
using System.Text;
using task0.Contracts;

namespace task0.Service
{
    class MediaService
    {
        private readonly IFileManager _fileManager;
        private readonly IPlayListManager _playListManager;
        private readonly ISearch _search;
        public MediaService(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }
        public MediaService(IPlayListManager playListManager)
        {
            _playListManager = playListManager;
        }
        public MediaService(ISearch search)
        {
            _search = search;
        }
    }
}
