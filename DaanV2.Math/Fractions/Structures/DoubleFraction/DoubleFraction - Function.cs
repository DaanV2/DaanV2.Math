/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct DoubleFraction {
        /// <summary>Converts this fraction to a double representation</summary>
        /// <returns>A double</returns>
        public Double ToDouble() {
            Double num = (Double)this.Numerator;
            Double den = (Double)this.Denominator;
            return num / den;
        }

        /// <summary>Converts this fraction to a single / float representation</summary>
        /// <returns>A double</returns>
        public Single ToSingle() {
            Single num = (Single)this.Numerator;
            Single den = (Single)this.Denominator;
            return num / den;
        }
    }
}
