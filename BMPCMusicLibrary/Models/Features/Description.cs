using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public class Description : Feature
    {
        public new string Value { get; set; }

        public Description()
        {
            ID = (int)FeatureType.Description;
            Name = "Description";
        }
    }
}