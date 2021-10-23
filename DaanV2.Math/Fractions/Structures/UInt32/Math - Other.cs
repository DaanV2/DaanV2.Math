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
        public static UInt32 Solve(UInt32Fraction A) {
            return (UInt32)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt32Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction Inverse(UInt32Fraction A) {
            return new UInt32Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A UInt32Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction Abs(UInt32Fraction A) {
            return new UInt32Fraction((UInt32)System.Math.Abs((Double)A.Numerator), (UInt32)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static UInt32Fraction Simplfy(UInt32Fraction A) {
        restart:
            UInt32 div = (UInt32)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                UInt32 num = (UInt32)(A.Numerator / div);
                if ((UInt32)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                UInt32 den = (UInt32)(A.Denominator / div);
                if ((UInt32)(den * div) != A.Denominator) continue;

                A = new UInt32Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
