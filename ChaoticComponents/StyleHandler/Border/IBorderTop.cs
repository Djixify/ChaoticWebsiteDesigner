using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderTop
    {
        public IBorderTop Color(Color color);
        public IBorderTop Color(byte r, byte g, byte b, byte a = 255);
        public IBorderTop Color(float r, float g, float b, float a = 1.0f);
        public IBorderTop Width(float width, AbsoluteLengths length);
        public IBorderTop Width(float width, RelativeLengths length);
        public IBorderTop Width(BorderWidth width);
        public IBorderTop Style(BorderStyle style);

    }
}
