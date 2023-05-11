using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderBlockEnd
    {
        public IBorderBlockEnd Color(Color color);
        public IBorderBlockEnd Color(byte r, byte g, byte b, byte a = 255);
        public IBorderBlockEnd Color(float r, float g, float b, float a = 1.0f);
        public IBorderBlockEnd Width(float width, AbsoluteLengths length);
        public IBorderBlockEnd Width(float width, RelativeLengths length);
        public IBorderBlockEnd Width(BorderWidth width);
        public IBorderBlockEnd Style(BorderStyle style);
    }
}
