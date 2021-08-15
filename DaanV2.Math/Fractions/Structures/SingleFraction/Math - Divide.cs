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
        public static SingleFraction Divide(Single numerator, Single denominator) {
            return new SingleFraction(numerator, denominator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static SingleFraction Divide(SingleFraction numerator, SingleFraction denominator) {
            //   1     7     1     9  
            //  --- / --- = --- * --- 
            //   5     9     5     7  

            return new SingleFraction(A.numerator * B.denominator, A.denominator * B.numerator);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static SingleFraction Divide(SingleFraction A, Single B) {
            return new SingleFraction(A.numerator, A.denominator * B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static SingleFraction Divide(Single B, SingleFraction A) {
            return new SingleFraction(A.denominator * B, A.numerator);
        }
    }
}
