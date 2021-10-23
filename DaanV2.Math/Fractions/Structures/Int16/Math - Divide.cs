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
        public static Int16Fraction Divide(Int16 numerator, Int16 denominator) {
            return new Int16Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Divide(Int16Fraction numerator, Int16Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new Int16Fraction((Int16)(numerator.Numerator * denominator.Denominator), (Int16)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Divide(Int16Fraction numerator, Int16 denominator) {
            return new Int16Fraction(numerator.Numerator, (Int16)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Divide(Int16 numerator, Int16Fraction denominator) {
            return new Int16Fraction((Int16)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
