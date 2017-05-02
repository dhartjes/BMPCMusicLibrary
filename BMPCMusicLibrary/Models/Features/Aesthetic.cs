using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Aesthetic : Feature
    {
        public new string Value { get; set; }

        public Aesthetic()
        {
            ID = (int)FeatureType.Aesthetic;
            Name = "Aesthetic";
        }
    }
}