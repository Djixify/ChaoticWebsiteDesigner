using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderBottom
    {
        public IBorderBottom Color(Color color);
        public IBorderBottom Color(byte r, byte g, byte b, byte a = 255);
        public IBorderBottom Color(float r, float g, float b, float a = 1.0f);
        public IBorderBottom Width(float width, AbsoluteLengths length);
        public IBorderBottom Width(float width, RelativeLengths length);
        public IBorderBottom Width(BorderWidth width);
        public IBorderBottom Style(BorderStyle style);
    }
}
