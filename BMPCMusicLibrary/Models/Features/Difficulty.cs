using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Difficulty : Feature
    {
        public new int Value { get; set; }

        public Difficulty()
        {
            ID = (int)FeatureType.Difficulty;
            Name = "Difficulty";
        }
    }
}