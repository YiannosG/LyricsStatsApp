using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyricsStats.Models
{  

    public class ArtistModel
    {
        public DateTime created { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
        public Artist[] artists { get; set; }
    }

    public class Artist
    {
        public string id { get; set; }
        public string type { get; set; }
        public string typeid { get; set; }
        public int score { get; set; }
        public string name { get; set; }
        public string sortname { get; set; }
        public string country { get; set; }     
        public string disambiguation { get; set; }
        public string[] isnis { get; set; }
    }

}
