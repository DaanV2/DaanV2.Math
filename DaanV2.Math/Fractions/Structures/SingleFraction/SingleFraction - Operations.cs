/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public partial struct SingleFraction {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator +(SingleFraction left, SingleFraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator +(SingleFraction left, Single right) {
            return Math.Addition(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator -(SingleFraction left, SingleFraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator -(SingleFraction left, Single right) {
            return Math.Substract(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator *(SingleFraction left, SingleFraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator *(SingleFraction left, Single right) {
            return Math.Multiply(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator /(SingleFraction left, SingleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator /(SingleFraction left, Single right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SingleFraction operator /(Single left, SingleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator SingleFraction(Single value) {
            return new SingleFraction(value, 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static explicit operator Single(SingleFraction value) {
            return Math.Solve(value);
        }
    }
}
