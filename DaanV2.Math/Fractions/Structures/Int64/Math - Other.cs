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
        public static Int64 Solve(Int64Fraction A) {
            return (Int64)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Inverse(Int64Fraction A) {
            return new Int64Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Abs(Int64Fraction A) {
            return new Int64Fraction((Int64)System.Math.Abs((Double)A.Numerator), (Int64)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static Int64Fraction Simplfy(Int64Fraction A) {
        restart:
            Int64 div = (Int64)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                Int64 num = (Int64)(A.Numerator / div);
                if ((Int64)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                Int64 den = (Int64)(A.Denominator / div);
                if ((Int64)(den * div) != A.Denominator) continue;

                A = new Int64Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
