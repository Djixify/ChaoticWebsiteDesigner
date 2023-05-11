using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChaoticComponents.StyleHandler.CssUnit;

namespace ChaoticComponents.StyleHandler
{
    public enum Attachment
    {
        Scroll,
        Fixed,
        Local,
        Initial,
        Inherit,
    }

    public enum BlendMode
    {
        Normal,
        Multiply,
        Screen,
        Overlay,
        Darken,
        Lighten,
        ColorDodge,
        Saturation,
        Color,
        Luminosity
    }

    public enum Clip
    {
        BorderBox,
        PaddingBox,
        ContentBox,
        Initial,
        Inherit
    }

    public enum Origin 
    {
        PaddingBox,
        BorderBox,
        ContentBox,
        Initial,
        Inherit
    }

    public enum PositionFirstParam
    {
        Left, Right, Center
    }
    public enum PositionSecondParam
    {
        Center, Top, Bottom, 
    }

    public enum Repeat
    {
        Repeat,
        RepeatX,
        RepeatY,
        NoRepeat,
        Space,
        Round,
        Initial,
        Inherit
    }

    public enum Size
    {
        Auto,
        Initial,
        Inherit,
    }

    public interface IBackground
    {
        IBackground Color(Color? color);
        IBackground Attachment(Attachment? attachment);
        IBackground BlendMode(BlendMode? blend);
        IBackground Clip(Clip clip);
        IBackground Image(string image);
        IBackground Image(Uri imageuri);
        IBackground Origin(Origin origin);
        IBackground Position(float x, float y, AbsoluteLengths unit);
        IBackground Position(float x, float y, RelativeLengths unit);
        IBackground Position(PositionFirstParam x, PositionSecondParam y);
        IBackground PositionX(float x, AbsoluteLengths unit);
        IBackground PositionX(float x, RelativeLengths unit);
        IBackground PositionY(float y, AbsoluteLengths unit);
        IBackground PositionY(float y, RelativeLengths unit);
        IBackground Repeat(Repeat repeat);
        IBackground Size(float s, AbsoluteLengths unit);
        IBackground Size(float s, RelativeLengths unit);
        IBackground Size(Size size);

    }
}
