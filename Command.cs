using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    abstract class Command
    {
        abstract public void Run();
        abstract public void Cancel();
    }
}
