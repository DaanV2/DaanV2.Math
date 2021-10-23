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
        public static UInt16 Solve(UInt16Fraction A) {
            return (UInt16)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Inverse(UInt16Fraction A) {
            return new UInt16Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Abs(UInt16Fraction A) {
            return new UInt16Fraction((UInt16)System.Math.Abs((Double)A.Numerator), (UInt16)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static UInt16Fraction Simplfy(UInt16Fraction A) {
        restart:
            UInt16 div = (UInt16)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                UInt16 num = (UInt16)(A.Numerator / div);
                if ((UInt16)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                UInt16 den = (UInt16)(A.Denominator / div);
                if ((UInt16)(den * div) != A.Denominator) continue;

                A = new UInt16Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
