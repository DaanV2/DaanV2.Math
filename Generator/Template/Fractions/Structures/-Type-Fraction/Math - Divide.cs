/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using DaanV2.Math.Fractions;

namespace DaanV2.Math {
    public static partial class Math {        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static %Type%Fraction Divide(%Type% numerator, %Type% denominator) {
            return new %Type%Fraction(numerator, denominator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static %Type%Fraction Divide(%Type%Fraction numerator, %Type%Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new %Type%Fraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static %Type%Fraction Divide(%Type%Fraction A, %Type% B) {
            return new %Type%Fraction(A.numerator, A.denominator * B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static %Type%Fraction Divide(%Type% B, %Type%Fraction A) {
            return new %Type%Fraction(A.denominator * B, A.numerator);
        }
    }
}
