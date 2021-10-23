/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct UInt64Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator +(UInt64Fraction left, UInt64Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator +(UInt64Fraction left, UInt64 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator -(UInt64Fraction left, UInt64Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator -(UInt64Fraction left, UInt64 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator *(UInt64Fraction left, UInt64Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator *(UInt64Fraction left, UInt64 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator /(UInt64Fraction left, UInt64Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator /(UInt64Fraction left, UInt64 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction operator /(UInt64 left, UInt64Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="UInt64"/> to <see cref="UInt64Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt64Fraction(UInt64 value) {
            return new UInt64Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="UInt64Fraction"/> to <see cref="UInt64"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt64"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt64(UInt64Fraction value) {
            return Math.Solve(value);
        }

        /// <summary>The explicit cast from <see cref="Tuple{UInt64, UInt64}"/> to <see cref="UInt64Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt64Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt64Fraction((UInt64 numerator, UInt64 denominator) v) {
            return new UInt64Fraction(v.numerator, v.denominator);
        }
    }
}
