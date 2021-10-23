/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct %Type%Fraction {
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

        /// <summary>Converts this fraction to a single number representation, this might result in turncating depending on the type</summary>
        /// <returns>A <see cref="%Type%"/></returns>
        public %Type% ToValue() {
            return Math.Solve(this);
        }

        /// <summary>Converts the string representation of a number to its %Type%-precision floating-point number equivalent.</summary>
        /// <param name="s">The string to parse</param>
        /// <returns>An <see cref="%Type%Fraction"/></returns>
        public static %Type%Fraction Parse(String s) {
            return Parse(s.AsSpan());
        }

        /// <summary>Converts the span representation of a number to its %Type%-precision floating-point number equivalent.</summary>
        /// <param name="s">The span to parse</param>
        /// <returns>An <see cref="%Type%Fraction"/></returns>
        public static %Type%Fraction Parse(ReadOnlySpan<Char> s) {
            Int32 Index = s.IndexOf('/');

            if (Index < 0) {
                throw new ArgumentException("string does not contain /");
            }

            ReadOnlySpan<Char> num = s[..Index];
            ReadOnlySpan<Char> den = s[(Index + 1)..];

            return new %Type%Fraction(%Type%.Parse(num), %Type%.Parse(den));
        }
    }
}
