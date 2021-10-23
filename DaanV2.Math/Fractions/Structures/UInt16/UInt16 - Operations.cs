/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct UInt16Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator +(UInt16Fraction left, UInt16Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator +(UInt16Fraction left, UInt16 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator -(UInt16Fraction left, UInt16Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator -(UInt16Fraction left, UInt16 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator *(UInt16Fraction left, UInt16Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator *(UInt16Fraction left, UInt16 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator /(UInt16Fraction left, UInt16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator /(UInt16Fraction left, UInt16 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction operator /(UInt16 left, UInt16Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="UInt16"/> to <see cref="UInt16Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt16Fraction(UInt16 value) {
            return new UInt16Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="UInt16Fraction"/> to <see cref="UInt16"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt16"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt16(UInt16Fraction value) {
            return Math.Solve(value);
        }

        /// <summary>The explicit cast from <see cref="Tuple{UInt16, UInt16}"/> to <see cref="UInt16Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt16Fraction((UInt16 numerator, UInt16 denominator) v) {
            return new UInt16Fraction(v.numerator, v.denominator);
        }        

        /// <summary>The explicit cast from <see cref="IFraction{UInt16}"/> to <see cref="UInt16Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt16Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt16Fraction(IFraction<UInt16> v) {
            return new UInt16Fraction(v.Numerator, v.Denominator);
        }
    }
}
