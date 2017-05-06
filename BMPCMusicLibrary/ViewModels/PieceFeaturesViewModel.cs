using BMPCMusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.ViewModels
{
    public class PieceFeaturesViewModel
    {
        public int PieceID { get; set; }
        public string PieceTitle { get; set; }
        public string PieceComposer { get; set; }
        public IEnumerable<Feature> Features { get; set; }
    }
}