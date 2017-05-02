using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class SubjectiveQuality : Feature
    {
        public new int Value { get; set; }

        public SubjectiveQuality()
        {
            ID = (int)FeatureType.SubjectiveQuality;
            Name = "Subjective Quality";
        }
    }
}