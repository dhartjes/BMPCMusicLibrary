using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.Models
{
    public abstract class Feature
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }

    public enum FeatureType
    {
        Difficulty,
        Note,
        Solo,
        WomenStart,
        Instruments,
        VocalParts,
        Aesthetic,
        TempoOrGroove,
        SubjectiveQuality,
        SeasonOrTheme
    }
}