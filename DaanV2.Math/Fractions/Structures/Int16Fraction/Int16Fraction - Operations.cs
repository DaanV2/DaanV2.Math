/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct Int16Fraction {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator +(Int16Fraction left, Int16Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator +(Int16Fraction left, Int16 right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator -(Int16Fraction left, Int16Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator -(Int16Fraction left, Int16 right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator *(Int16Fraction left, Int16Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator *(Int16Fraction left, Int16 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator /(Int16Fraction left, Int16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator /(Int16Fraction left, Int16 right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Int16Fraction operator /(Int16 left, Int16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Int16Fraction(Int16 value) {
            return new Int16Fraction(value, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Int16(Int16Fraction value) {
            return Math.Solve(value);
        }
    }
}
