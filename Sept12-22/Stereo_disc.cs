using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class Stereo_disc : Attribute
    {
        public string songname { get; set; }
        public string lyrics { get; set; }
   
    public string language { get; set; }
        public Stereo_disc(string songname)
        {

            this.songname = songname;

        }

    }
   
}

