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
        public static Int64Fraction Divide(Int64 numerator, Int64 denominator) {
            return new Int64Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static Int64Fraction Divide(Int64Fraction numerator, Int64Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new Int64Fraction((Int64)(numerator.Numerator * denominator.Denominator), (Int64)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static Int64Fraction Divide(Int64Fraction numerator, Int64 denominator) {
            return new Int64Fraction(numerator.Numerator, (Int64)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static Int64Fraction Divide(Int64 numerator, Int64Fraction denominator) {
            return new Int64Fraction((Int64)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
