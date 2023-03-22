using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDPlayer.Object
{
    public class PlayList
    {
        public PlayList()
        {
        }

        public PlayList(string title, string path, TimeSpan totalTime, int amount)
        {
            Title = title;
            Path = path;
            TotalTime = totalTime;
            Amount = amount;
        }

        public PlayList(string title, string path, string image, TimeSpan totalTime, int amount)
        {
            Title = title;
            Path = path;
            this.image = image;
            TotalTime = totalTime;
            Amount = amount;
        }

        public string Title { get; set; }
        public string Path { get; set; }

        public string image { get; set; } = "";

        public TimeSpan TotalTime { get; set; } = new TimeSpan(0);

        public int Amount { get; set; }
    }
}
