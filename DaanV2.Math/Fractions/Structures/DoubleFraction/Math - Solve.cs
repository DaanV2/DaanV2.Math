using System;
using DaanV2.Math.Fractions;

namespace DaanV2.Math {
    public static partial class Math {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fraction"></param>
        /// <returns></returns>
        public static Double Solve(DoubleFraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }
    }
}
