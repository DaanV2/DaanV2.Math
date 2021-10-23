/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct UInt32Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator +(UInt32Fraction left, UInt32Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator +(UInt32Fraction left, UInt32 right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator -(UInt32Fraction left, UInt32Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator -(UInt32Fraction left, UInt32 right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator *(UInt32Fraction left, UInt32Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator *(UInt32Fraction left, UInt32 right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator /(UInt32Fraction left, UInt32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator /(UInt32Fraction left, UInt32 right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32Fraction operator /(UInt32 left, UInt32Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="UInt32"/> to <see cref="UInt32Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt32Fraction(UInt32 value) {
            return new UInt32Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="UInt32Fraction"/> to <see cref="UInt32"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt32"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt32(UInt32Fraction value) {
            return Math.Solve(value);
        }

        /// <summary>The explicit cast from <see cref="Tuple{UInt32, UInt32}"/> to <see cref="UInt32Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt32Fraction((UInt32 numerator, UInt32 denominator) v) {
            return new UInt32Fraction(v.numerator, v.denominator);
        }        

        /// <summary>The explicit cast from <see cref="IFraction{UInt32}"/> to <see cref="UInt32Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="UInt32Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt32Fraction(IFraction<UInt32> v) {
            return new UInt32Fraction(v.Numerator, v.Denominator);
        }
    }
}
