using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public FeatureType FeatureType { get; set; }
    }

    public enum FeatureType
    {
        Difficulty,
        Description,
        Solo,
        [Display(Name = "Women Start")]
        WomenStart,
        Instruments,
        [Display(Name = "Vocal Parts")]
        VocalParts,
        Aesthetic,
        [Display(Name = "Tempo or Groove")]
        TempoOrGroove,
        [Display(Name = "Subjective Quality")]
        SubjectiveQuality,
        [Display(Name = "Season or Theme")]
        SeasonOrTheme
    }
}