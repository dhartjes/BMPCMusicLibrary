using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class WomenStart : Feature
    {
        public new bool Value { get; set; }

        public WomenStart()
        {
            ID = (int)FeatureType.WomenStart;
            Name = "Women Start";
        }
    }
}