/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct DoubleFraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator +(DoubleFraction left, DoubleFraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator +(DoubleFraction left, Double right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator -(DoubleFraction left, DoubleFraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator -(DoubleFraction left, Double right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator *(DoubleFraction left, DoubleFraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator *(DoubleFraction left, Double right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator /(DoubleFraction left, DoubleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator /(DoubleFraction left, Double right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static DoubleFraction operator /(Double left, DoubleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="Double"/> to <see cref="DoubleFraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="DoubleFraction"/></returns>
        public static explicit operator DoubleFraction(Double value) {
            return new DoubleFraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="DoubleFraction"/> to <see cref="Double"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Double"/></returns>
        public static explicit operator Double(DoubleFraction value) {
            return Math.Solve(value);
        }
    }
}
