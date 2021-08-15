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
        public static Int64Fraction Divide(Int64 numerator, Int64 denominator) {
            return new Int64Fraction(numerator, denominator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int64Fraction Divide(Int64Fraction numerator, Int64Fraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new Int64Fraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int64Fraction Divide(Int64Fraction A, Int64 B) {
            return new Int64Fraction(A.numerator, A.denominator * B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static Int64Fraction Divide(Int64 B, Int64Fraction A) {
            return new Int64Fraction(A.denominator * B, A.numerator);
        }
    }
}
