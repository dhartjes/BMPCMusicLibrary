using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class SeasonOrTheme : Feature
    {
        public new string Value { get; set; }

        public SeasonOrTheme()
        {
            ID = (int)FeatureType.SeasonOrTheme;
            Name = "Season or Theme";
        }
    }
}