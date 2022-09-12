using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    internal class Song
    {
        public string songname { get; set; }
        [Stereo_disc("Name of the song : ",songname = "Gaana")]
        public string language { get; set; }
        [Stereo_disc("Language of the song : ", language = "Tamil")]
        

        [Stereo_disc("Lyrics:", lyrics ="saregama")]
        public string lyrics { get; set; }

        public Song(string name, string l, string lyric)
        {
            songname = name;
            language = l;
            lyrics = lyric;
        }
       
    }
}
