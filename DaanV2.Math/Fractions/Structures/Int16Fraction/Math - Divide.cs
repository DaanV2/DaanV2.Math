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
        public static Int16Fraction Divide(Int16 numerator, Int16 denominator) {
            return new Int16Fraction(numerator, denominator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int16Fraction Divide(Int16Fraction numerator, Int16Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new Int16Fraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int16Fraction Divide(Int16Fraction A, Int16 B) {
            return new Int16Fraction(A.numerator, A.denominator * B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int16Fraction Divide(Int16 B, Int16Fraction A) {
            return new Int16Fraction(A.denominator * B, A.numerator);
        }
    }
}
