/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;

namespace DaanV2.Math.Fractions {
    public readonly partial struct Int16Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator +(Int16Fraction left, Int16Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator +(Int16Fraction left, Int16 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator -(Int16Fraction left, Int16Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator -(Int16Fraction left, Int16 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator *(Int16Fraction left, Int16Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator *(Int16Fraction left, Int16 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator /(Int16Fraction left, Int16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator /(Int16Fraction left, Int16 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static Int16Fraction operator /(Int16 left, Int16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="Int16"/> to <see cref="Int16Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int16Fraction"/></returns>
        public static explicit operator Int16Fraction(Int16 value) {
            return new Int16Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="Int16Fraction"/> to <see cref="Int16"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Int16"/></returns>
        public static explicit operator Int16(Int16Fraction value) {
            return Math.Solve(value);
        }
    }
}
