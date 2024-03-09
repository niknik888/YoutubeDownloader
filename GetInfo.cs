using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeDownloader
{
    internal class GetInfo
    {
        YoutubeClient youtube = new YoutubeClient();
        string videoUrl;

        public GetInfo(string _videoUrl)
        {
            videoUrl = _videoUrl;
        }

        internal async Task GetAsync()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Video Info:");
            Console.WriteLine(await youtube.Videos.GetAsync(videoUrl));
            Console.WriteLine("--------------------------------------");
        }
    }
}
