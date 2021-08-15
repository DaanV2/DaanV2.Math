/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct %Type%Fraction {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator +(%Type%Fraction left, %Type%Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator +(%Type%Fraction left, %Type% right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator -(%Type%Fraction left, %Type%Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator -(%Type%Fraction left, %Type% right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator *(%Type%Fraction left, %Type%Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator *(%Type%Fraction left, %Type% right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator /(%Type%Fraction left, %Type%Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator /(%Type%Fraction left, %Type% right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static %Type%Fraction operator /(%Type% left, %Type%Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator %Type%Fraction(%Type% value) {
            return new %Type%Fraction(value, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator %Type%(%Type%Fraction value) {
            return Math.Solve(value);
        }
    }
}
