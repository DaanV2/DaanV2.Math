/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using DaanV2.Math.Fractions;
using System.Runtime.CompilerServices;

namespace DaanV2.Math {
    public static partial class Math {        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Divide(UInt64 numerator, UInt64 denominator) {
            return new UInt64Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Divide(UInt64Fraction numerator, UInt64Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new UInt64Fraction((UInt64)(numerator.Numerator * denominator.Denominator), (UInt64)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Divide(UInt64Fraction numerator, UInt64 denominator) {
            return new UInt64Fraction(numerator.Numerator, (UInt64)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Divide(UInt64 numerator, UInt64Fraction denominator) {
            return new UInt64Fraction((UInt64)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
