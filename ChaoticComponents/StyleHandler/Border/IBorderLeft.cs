using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderLeft
    {
        public IBorderLeft Color(Color color);
        public IBorderLeft Color(byte r, byte g, byte b, byte a = 255);
        public IBorderLeft Color(float r, float g, float b, float a = 1.0f);
        public IBorderLeft Width(float width, AbsoluteLengths length);
        public IBorderLeft Width(float width, RelativeLengths length);
        public IBorderLeft Width(BorderWidth width);
        public IBorderLeft Style(BorderStyle style);
    }
}
