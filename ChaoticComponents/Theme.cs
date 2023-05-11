using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaoticComponents
{
    public class LayoutTheme
    {
        public enum Theme
        {
            Primary,
            Secondary,
            Tertiary,
            Background
        }
        public Color Primary { get; set; } = Color.DarkViolet;
        public Color Secondary { get; set; } = Color.DimGray;
        public Color Tertiary { get; set; } = Color.WhiteSmoke;
        public Color Background { get; set; } = Color.Wheat;
    }
}
