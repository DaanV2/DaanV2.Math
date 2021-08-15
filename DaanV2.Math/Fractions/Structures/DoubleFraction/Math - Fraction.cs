using System;
using DaanV2.Math.Fractions;

namespace DaanV2.Math {
    public static partial class Math {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static DoubleFraction Divide(Double numerator, Double denominator) {
            return new DoubleFraction(denominator, numerator);
        }
    }
}
