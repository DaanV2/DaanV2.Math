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
        public static Int32 Solve(Int32Fraction A) {
            return (Int32)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int32Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Inverse(Int32Fraction A) {
            return new Int32Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A Int32Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Abs(Int32Fraction A) {
            return new Int32Fraction((Int32)System.Math.Abs((Double)A.Numerator), (Int32)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static Int32Fraction Simplfy(Int32Fraction A) {
        restart:
            Int32 div = (Int32)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                Int32 num = (Int32)(A.Numerator / div);
                if ((Int32)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                Int32 den = (Int32)(A.Denominator / div);
                if ((Int32)(den * div) != A.Denominator) continue;

                A = new Int32Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
