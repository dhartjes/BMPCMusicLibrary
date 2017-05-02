using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models
{
    public class Recording
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public string Poster { get; set; }

        public int PieceID { get; set; }
        public virtual Piece Piece { get; set; }
    }
}