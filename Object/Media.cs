using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDPlayer.Object
{
    [Serializable]
    public class Media
    {
        public string Title { get; set; } = "Song Title";
        public string Author { get; set; } = "Author";
        public string Path { get; set; } = "";
        public TimeSpan Time { get; set; } = new TimeSpan(0);

        public Media(string title, string author, string path, TimeSpan time)
        {
            if (!title.Equals("") && !title.Equals(Title)) Title = title;
            if(!author.Equals("") && !author.Equals(Author)) Author = author;
            Path = path;
            Time = time;
        }

        public Media()
        {
        }
    }
}
