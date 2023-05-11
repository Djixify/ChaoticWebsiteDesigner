using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderBlock
    {
        public IBorderBlock Color(Color color);
        public IBorderBlock Color(byte r, byte g, byte b, byte a = 255);
        public IBorderBlock Color(float r, float g, float b, float a = 1.0f);
        public IBorderBlock Width(float width, AbsoluteLengths length);
        public IBorderBlock Width(float width, RelativeLengths length);
        public IBorderBlock Width(BorderWidth width);
        public IBorderBlock Style(BorderStyle style);
        public IBorderBlock Start(Action<IBorderBlockStart> configure);
        public IBorderBlock End(Action<IBorderBlockEnd> configure);
    }
}
