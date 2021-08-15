/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using DaanV2.Math.Fractions;

namespace DaanV2.Math {
    public static partial class Math {        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static UInt16Fraction Divide(UInt16 numerator, UInt16 denominator) {
            return new UInt16Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static UInt16Fraction Divide(UInt16Fraction numerator, UInt16Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new UInt16Fraction((UInt16)(numerator.Numerator * denominator.Denominator), (UInt16)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static UInt16Fraction Divide(UInt16Fraction numerator, UInt16 denominator) {
            return new UInt16Fraction(numerator.Numerator, (UInt16)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static UInt16Fraction Divide(UInt16 numerator, UInt16Fraction denominator) {
            return new UInt16Fraction((UInt16)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
