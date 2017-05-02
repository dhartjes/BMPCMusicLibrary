using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models.Features
{
    public enum VocalPartTypes
    {
        S,
        A,
        T,
        B
    }

    public class VocalParts : Feature
    {
        public new ICollection<VocalPartTypes> Value { get; set; }

        public VocalParts()
        {
            ID = (int)FeatureType.VocalParts;
            Name = "Vocal Parts";
        }
    }
}