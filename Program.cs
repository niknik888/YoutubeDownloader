using CliWrap;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader 
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string videoUrl = "https://www.youtube.com/watch?v=ex9tML6udCU";
            
            var info = new GetInfo(videoUrl);
            var commandOne = new GetInfoCommand(info);
            commandOne.Run();

            var file = new Download(videoUrl);
            var commandTwo = new DownloadCommancd(file);
            commandTwo.Run();
        }
    }
}