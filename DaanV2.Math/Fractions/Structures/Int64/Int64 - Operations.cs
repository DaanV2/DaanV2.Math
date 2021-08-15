/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct Int64Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator +(Int64Fraction left, Int64Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator +(Int64Fraction left, Int64 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator -(Int64Fraction left, Int64Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator -(Int64Fraction left, Int64 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator *(Int64Fraction left, Int64Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator *(Int64Fraction left, Int64 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator /(Int64Fraction left, Int64Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator /(Int64Fraction left, Int64 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static Int64Fraction operator /(Int64 left, Int64Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="Int64"/> to <see cref="Int64Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int64Fraction"/></returns>
        public static explicit operator Int64Fraction(Int64 value) {
            return new Int64Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="Int64Fraction"/> to <see cref="Int64"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int64"/></returns>
        public static explicit operator Int64(Int64Fraction value) {
            return Math.Solve(value);
        }
    }
}
