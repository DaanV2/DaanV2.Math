/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct %Type%Fraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator +(%Type%Fraction left, %Type%Fraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator +(%Type%Fraction left, %Type% right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator -(%Type%Fraction left, %Type%Fraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator -(%Type%Fraction left, %Type% right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator *(%Type%Fraction left, %Type%Fraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator *(%Type%Fraction left, %Type% right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator /(%Type%Fraction left, %Type%Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator /(%Type%Fraction left, %Type% right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction operator /(%Type% left, %Type%Fraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="%Type%"/> to <see cref="%Type%Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator %Type%Fraction(%Type% value) {
            return new %Type%Fraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="%Type%Fraction"/> to <see cref="%Type%"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="%Type%"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator %Type%(%Type%Fraction value) {
            return Math.Solve(value);
        }

        /// <summary>The explicit cast from <see cref="Tuple{%Type%, %Type%}"/> to <see cref="%Type%Fraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="%Type%Fraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator %Type%Fraction((%Type% numerator, %Type% denominator) v) {
            return new %Type%Fraction(v.numerator, v.denominator);
        }
    }
}
