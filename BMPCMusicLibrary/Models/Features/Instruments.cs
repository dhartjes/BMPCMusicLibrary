using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Instruments : Feature
    {
        public new string Value { get; set; }

        public Instruments()
        {
            ID = (int)FeatureType.Instruments;
            Name = "Instruments";
        }
    }
}