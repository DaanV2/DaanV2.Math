/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct DoubleFraction {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator +(DoubleFraction left, DoubleFraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator +(DoubleFraction left, Double right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator -(DoubleFraction left, DoubleFraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator -(DoubleFraction left, Double right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator *(DoubleFraction left, DoubleFraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator *(DoubleFraction left, Double right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator /(DoubleFraction left, DoubleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator /(DoubleFraction left, Double right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static DoubleFraction operator /(Double left, DoubleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator DoubleFraction(Double value) {
            return new DoubleFraction(value, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Double(DoubleFraction value) {
            return Math.Solve(value);
        }
    }
}
