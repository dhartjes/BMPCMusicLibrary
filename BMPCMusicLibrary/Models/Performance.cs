using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models
{
    public class Performance
    {
        public int ID { get; set; }
        public int PieceID { get; set; }
        public DateTime DatePerformed { get; set; }
        public string ThemeOrOccasion { get; set; }

        public virtual Piece Piece { get; set; }
    }
}