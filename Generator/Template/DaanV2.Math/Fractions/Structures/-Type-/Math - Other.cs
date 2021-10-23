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
        public static %Type% Solve(%Type%Fraction A) {
            return (%Type%)(A.Numerator / A.Denominator);
        }

        /// <summary>Inveres the numerator with the denominator</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Inverse(%Type%Fraction A) {
            return new %Type%Fraction(A.Denominator, A.Numerator);
        }

        /// <summary>Calculates the Absolute fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Abs(%Type%Fraction A) {
            return new %Type%Fraction((%Type%)System.Math.Abs((Double)A.Numerator), (%Type%)System.Math.Abs((Double)A.Denominator)); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static %Type%Fraction Simplfy(%Type%Fraction A) {
        restart:
            %Type% div = (%Type%)(System.Math.Min(A.Numerator, A.Denominator) / 2);

            for (; div > 1; div--) {
                //If numerator has been turncated
                %Type% num = (%Type%)(A.Numerator / div);
                if ((%Type%)(num * div) != A.Numerator) continue;

                //If denominator has been turncated
                %Type% den = (%Type%)(A.Denominator / div);
                if ((%Type%)(den * div) != A.Denominator) continue;

                A = new %Type%Fraction(num, den);
                goto restart;
            }

            return A;
        }
    }
}
