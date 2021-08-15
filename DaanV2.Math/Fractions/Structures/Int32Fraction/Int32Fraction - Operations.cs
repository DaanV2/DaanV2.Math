/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct Int32Fraction {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator +(Int32Fraction left, Int32Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator +(Int32Fraction left, Int32 right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator -(Int32Fraction left, Int32Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator -(Int32Fraction left, Int32 right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator *(Int32Fraction left, Int32Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator *(Int32Fraction left, Int32 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator /(Int32Fraction left, Int32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator /(Int32Fraction left, Int32 right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int32Fraction operator /(Int32 left, Int32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Int32Fraction(Int32 value) {
            return new Int32Fraction(value, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Int32(Int32Fraction value) {
            return Math.Solve(value);
        }
    }
}
