using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaoticComponents.StyleHandler
{
    public static class CssUnit
    {
        /// <summary>
        /// <para>Sets the absolute length to a given unit based on DPI of the display</para>
        /// <see cref="AbsoluteLengths.Cm"/> : Centimeter
        /// <see cref="AbsoluteLengths.Mm"/> : Millimeter
        /// <see cref="AbsoluteLengths.In"/> : Inches
        /// <see cref="AbsoluteLengths.Px"/> : Pixels
        /// <see cref="AbsoluteLengths.Pt"/> : Points
        /// <see cref="AbsoluteLengths.Pc"/> : Picas
        /// </summary>
        public enum AbsoluteLengths
        {
            Cm,
            Mm,
            In,
            Px,
            Pt,
            Pc,
        }

        /// <summary>
        /// <para>Sets a relative length based on parent, root or viewport sizes</para>
        /// <see cref="RelativeLengths.Em"/>      : Fontsize scaling<br/>
        /// <see cref="RelativeLengths.Ex"/>      : Font height scaling<br/>
        /// <see cref="RelativeLengths.Ch"/>      : Font width scaling<br/>
        /// <see cref="RelativeLengths.Rem"/>     : Relative fontsize to root element<br/>
        /// <see cref="RelativeLengths.Vw"/>      : Relative to 1% of the viewport width<br/>
        /// <see cref="RelativeLengths.Vh"/>      : Relative to 1% of the viewport height<br/>
        /// <see cref="RelativeLengths.Vmin"/>    : Relative to 1% of the viewports smaller dimension<br/>
        /// <see cref="RelativeLengths.Vmax"/>    : Relative to 1% of the viewports larger dimension<br/>
        /// <see cref="RelativeLengths.Percent"/> : Percentage of the parent element<br/>
        /// </summary>
        public enum RelativeLengths
        {
            Em,
            Ex,
            Ch,
            Rem,
            Vw,
            Vh,
            Vmin,
            Vmax,
            Percent
        }
    }
}
