/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct DoubleFraction {
        /// <summary>Converts this fraction to a double representation</summary>
        /// <returns>A <see cref="Double"/></returns>
        public Double ToDouble() {
            Double num = (Double)this.Numerator;
            Double den = (Double)this.Denominator;
            return num / den;
        }

        /// <summary>Converts this fraction to a single / float representation</summary>
        /// <returns>A <see cref="Single"/></returns>
        public Single ToSingle() {
            Single num = (Single)this.Numerator;
            Single den = (Single)this.Denominator;
            return num / den;
        }

        /// <summary>Converts the string representation of a number to its Double-precision floating-point number equivalent.</summary>
        /// <param name="s">The string to parse</param>
        /// <returns>An <see cref="DoubleFraction"/></returns>
        public static DoubleFraction Parse(String s) {
            return Parse(s.AsSpan());
        }

        /// <summary>Converts the span representation of a number to its Double-precision floating-point number equivalent.</summary>
        /// <param name="s">The span to parse</param>
        /// <returns>An <see cref="DoubleFraction"/></returns>
        public static DoubleFraction Parse(ReadOnlySpan<Char> s) {
            Int32 Index = s.IndexOf('/');

            if (Index < 0) {
                throw new ArgumentException("string does not contain /");
            }

            ReadOnlySpan<Char> num = s[..Index];
            ReadOnlySpan<Char> den = s[(Index + 1)..];

            return new DoubleFraction(Double.Parse(num), Double.Parse(den));
        }
    }
}
