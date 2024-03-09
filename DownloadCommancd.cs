using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    internal class DownloadCommancd : Command
    {
        Download download;
        public DownloadCommancd(Download _dowland) 
        {
            download = _dowland;
        }

        public override void Cancel() { }

        public override void Run()
        {
            download.DownloadAsync().Wait();
        }
    }
}
