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
        public static Int32Fraction Divide(Int32 numerator, Int32 denominator) {
            return new Int32Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Divide(Int32Fraction numerator, Int32Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new Int32Fraction((Int32)(numerator.Numerator * denominator.Denominator), (Int32)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Divide(Int32Fraction numerator, Int32 denominator) {
            return new Int32Fraction(numerator.Numerator, (Int32)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Divide(Int32 numerator, Int32Fraction denominator) {
            return new Int32Fraction((Int32)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
