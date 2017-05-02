using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models
{
    public class Piece
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }

        public virtual ICollection<Recording> Recordings { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
    }
}