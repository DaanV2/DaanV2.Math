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
        public static Single Solve(SingleFraction A) {
            return (Single)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Inverse(SingleFraction A) {
            return new SingleFraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Abs(SingleFraction A) {
            return new SingleFraction((Single)System.Math.Abs((Double)A.Numerator), (Single)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static SingleFraction Simplfy(SingleFraction A) {
        restart:
            Single div = (Single)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                Single num = (Single)(A.Numerator / div);
                if ((Single)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                Single den = (Single)(A.Denominator / div);
                if ((Single)(den * div) != A.Denominator) continue;

                A = new SingleFraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
