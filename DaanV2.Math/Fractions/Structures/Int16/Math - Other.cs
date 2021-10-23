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
        public static Int16 Solve(Int16Fraction A) {
            return (Int16)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Inverse(Int16Fraction A) {
            return new Int16Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Abs(Int16Fraction A) {
            return new Int16Fraction((Int16)System.Math.Abs((Double)A.Numerator), (Int16)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static Int16Fraction Simplfy(Int16Fraction A) {
        restart:
            Int16 div = (Int16)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                Int16 num = (Int16)(A.Numerator / div);
                if ((Int16)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                Int16 den = (Int16)(A.Denominator / div);
                if ((Int16)(den * div) != A.Denominator) continue;

                A = new Int16Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
