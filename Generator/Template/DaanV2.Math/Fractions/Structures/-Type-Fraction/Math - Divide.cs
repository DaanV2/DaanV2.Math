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
        public static %Type%Fraction Divide(%Type% numerator, %Type% denominator) {
            return new %Type%Fraction(numerator, denominator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static %Type%Fraction Divide(%Type%Fraction numerator, %Type%Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new %Type%Fraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static %Type%Fraction Divide(%Type%Fraction A, %Type% B) {
            return new %Type%Fraction(A.numerator, A.denominator * B);
        }

        /// <summary>Preforms the division operation on the given data:    numerator / denominator = result</summary>
        /// <param name="numerator">The numerator value of the division</param>
        /// <param name="denominator">The denominator of the division</param>
        /// <returns>A fraction representing the division</returns>
        public static %Type%Fraction Divide(%Type% B, %Type%Fraction A) {
            return new %Type%Fraction(A.denominator * B, A.numerator);
        }
    }
}
