/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct Int32Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator +(Int32Fraction left, Int32Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator +(Int32Fraction left, Int32 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator -(Int32Fraction left, Int32Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator -(Int32Fraction left, Int32 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator *(Int32Fraction left, Int32Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator *(Int32Fraction left, Int32 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator /(Int32Fraction left, Int32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator /(Int32Fraction left, Int32 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static Int32Fraction operator /(Int32 left, Int32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="Int32"/> to <see cref="Int32Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int32Fraction"/></returns>
        public static explicit operator Int32Fraction(Int32 value) {
            return new Int32Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="Int32Fraction"/> to <see cref="Int32"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int32"/></returns>
        public static explicit operator Int32(Int32Fraction value) {
            return Math.Solve(value);
        }
    }
}
