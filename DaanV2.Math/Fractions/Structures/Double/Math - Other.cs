/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using DaanV2.Math.Fractions;
using System.Runtime.CompilerServices;

namespace DaanV2.Math {
    public static partial class Math {        
        /// <summary>Solves the fraction into a single value</summary>
        /// <param name="Fraction">The fraction to solve</param>
        /// <returns>The value of the fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Solve(DoubleFraction A) {
            return (Double)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Inverse(DoubleFraction A) {
            return new DoubleFraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Abs(DoubleFraction A) {
            return new DoubleFraction((Double)System.Math.Abs((Double)A.Numerator), (Double)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static DoubleFraction Simplfy(DoubleFraction A) {
        restart:
            Double div = (Double)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                Double num = (Double)(A.Numerator / div);
                if ((Double)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                Double den = (Double)(A.Denominator / div);
                if ((Double)(den * div) != A.Denominator) continue;

                A = new DoubleFraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
