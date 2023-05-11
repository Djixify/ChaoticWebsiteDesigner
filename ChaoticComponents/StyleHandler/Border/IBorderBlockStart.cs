﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler.Border
{
    public interface IBorderBlockStart
    {
        public IBorderBlockStart Color(Color color);
        public IBorderBlockStart Color(byte r, byte g, byte b, byte a = 255);
        public IBorderBlockStart Color(float r, float g, float b, float a = 1.0f);
        public IBorderBlockStart Width(float width, AbsoluteLengths length);
        public IBorderBlockStart Width(float width, RelativeLengths length);
        public IBorderBlockStart Width(BorderWidth width);
        public IBorderBlockStart Style(BorderStyle style);
    }
}
