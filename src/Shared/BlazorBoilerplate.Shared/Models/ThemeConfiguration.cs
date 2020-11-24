using BlazorBoilerplate.Shared.Dto.Db;
using System.ComponentModel.DataAnnotations;

namespace BlazorBoilerplate.Shared.Models
{
    public class ThemeConfiguration
    {
        public string PrimaryColor { get; set; }
        //ThemeConfiguration_PrimaryColor,
        public string SecondaryColor { get; set; }
        //ThemeConfiguration_SecondaryColor,
        public string OnPrimaryColor { get; set; }
        //ThemeConfiguration_OnPrimaryColor,
        public string OnSecondaryColor { get; set; }
        //ThemeConfiguration_OnSecondaryColor,

        public string TextPrimaryColor { get; set; }
        //ThemeConfiguration_TextPrimaryColor,
        public string TextSecondaryColor { get; set; }
        //ThemeConfiguration_TextSecondaryColor,

        public string Background { get; set; }
        //ThemeConfiguration_Background,
        public string OnSurface { get; set; }
        //ThemeConfiguration_OnBackground,
        public string Surface { get; set; }
        //ThemeConfiguration_Surface,

        public string NavPrimaryColor { get; set; }
        //ThemeConfiguration_NavPrimaryColor,
        public string NavSecondaryColor { get; set; }
        //ThemeConfiguration_NavSecondaryColor,
        public string NavPaintType { get; set; } //Single Color or Gradient
        //ThemeConfiguration_NavPaintType,
        [Range(0, 360)]
        public int NavOrientation { get; set; }
        //ThemeConfiguration_NavOrientation,
        [Range(0, 200)]
        public int NavSplit { get; set; }
        //ThemeConfiguration_NavSplit
    }
}
