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
        public static UInt64 Solve(UInt64Fraction A) {
            return (UInt64)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Inverse(UInt64Fraction A) {
            return new UInt64Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Abs(UInt64Fraction A) {
            return new UInt64Fraction((UInt64)System.Math.Abs((Double)A.Numerator), (UInt64)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static UInt64Fraction Simplfy(UInt64Fraction A) {
        restart:
            UInt64 div = (UInt64)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                UInt64 num = (UInt64)(A.Numerator / div);
                if ((UInt64)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                UInt64 den = (UInt64)(A.Denominator / div);
                if ((UInt64)(den * div) != A.Denominator) continue;

                A = new UInt64Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
