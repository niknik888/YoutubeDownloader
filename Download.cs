using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using CliWrap;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    internal class Download
    {
        YoutubeClient youtube = new YoutubeClient();
        string videoUrl;

        public Download(string _videoUrl)
        {
            videoUrl = _videoUrl;
        }

        public async Task DownloadAsync() 
        {
            var video = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"downloadedVideo.{streamInfo.Container}");

            Console.WriteLine($"Video was download at: {Environment.CurrentDirectory}");

        }
    }
}
