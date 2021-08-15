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
        public static SingleFraction Divide(Single numerator, Single denominator) {
            return new SingleFraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static SingleFraction Divide(SingleFraction numerator, SingleFraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new SingleFraction((Single)(numerator.Numerator * denominator.Denominator), (Single)(numerator.Denominator * denominator.Numerator));
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static SingleFraction Divide(SingleFraction numerator, Single denominator) {
            return new SingleFraction(numerator.Numerator, (Single)(numerator.Denominator * denominator));
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static SingleFraction Divide(Single numerator, SingleFraction denominator) {
            return new SingleFraction((Single)(denominator.Denominator * numerator), denominator.Numerator);
        }
    }
}
