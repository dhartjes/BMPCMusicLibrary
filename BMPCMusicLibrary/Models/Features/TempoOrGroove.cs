using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class TempoOrGroove : Feature
    {
        public new string Value { get; set; }

        public TempoOrGroove()
        {
            ID = (int)FeatureType.TempoOrGroove;
            Name = "Tempo or Groove";
        }
    }
}