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
        public static DoubleFraction Divide(Double numerator, Double denominator) {
            return new DoubleFraction(numerator, denominator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static DoubleFraction Divide(DoubleFraction numerator, DoubleFraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new DoubleFraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static DoubleFraction Divide(DoubleFraction A, Double B) {
            return new DoubleFraction(A.numerator, A.denominator * B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static DoubleFraction Divide(Double B, DoubleFraction A) {
            return new DoubleFraction(A.denominator * B, A.numerator);
        }
    }
}
