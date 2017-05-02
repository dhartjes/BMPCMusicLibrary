using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Note : Feature
    {
        public new string Value { get; set; }

        public Note()
        {
            ID = (int)FeatureType.Note;
            Name = "Note";
        }
    }
}