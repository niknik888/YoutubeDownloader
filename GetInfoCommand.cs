using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    internal class GetInfoCommand : Command
    {
        GetInfo getInfo;
        public GetInfoCommand(GetInfo _getInfo) 
        {
            getInfo = _getInfo;
        }

        public override void Cancel() { }

        public override void Run()
        {
            getInfo.GetAsync().Wait();
        }
    }
}
