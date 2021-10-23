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
        public static DoubleFraction Divide(Double numerator, Double denominator) {
            return new DoubleFraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Divide(DoubleFraction numerator, DoubleFraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new DoubleFraction((Double)(numerator.Numerator * denominator.Denominator), (Double)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Divide(DoubleFraction numerator, Double denominator) {
            return new DoubleFraction(numerator.Numerator, (Double)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Divide(Double numerator, DoubleFraction denominator) {
            return new DoubleFraction((Double)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
