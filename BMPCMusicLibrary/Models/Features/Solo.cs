using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Solo : Feature
    {
        public new bool Value { get; set; }

        public Solo()
        {
            ID = (int)FeatureType.Solo;
            Name = "Solo";
        }
    }
}