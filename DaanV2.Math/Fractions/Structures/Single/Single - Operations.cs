/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Math.Fractions {
    public readonly partial struct SingleFraction {
        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator +(SingleFraction left, SingleFraction right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the addition operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator +(SingleFraction left, Single right) {
            return Math.Addition(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator -(SingleFraction left, SingleFraction right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the substraction operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator -(SingleFraction left, Single right) {
            return Math.Substract(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator *(SingleFraction left, SingleFraction right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the multiplication operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator *(SingleFraction left, Single right) {
            return Math.Multiply(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator /(SingleFraction left, SingleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator /(SingleFraction left, Single right) {
            return Math.Divide(left, right);
        }

        /// <summary>Preforms the division operations on the given data</summary>
        /// <param name="left">The first value</param>
        /// <param name="right">The second value</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction operator /(Single left, SingleFraction right) {
            return Math.Divide(left, right);
        }

        /// <summary>The explicit cast from <see cref="Single"/> to <see cref="SingleFraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator SingleFraction(Single value) {
            return new SingleFraction(value, 1);
        }

        /// <summary>The explicit cast from <see cref="SingleFraction"/> to <see cref="Single"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="Single"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Single(SingleFraction value) {
            return Math.Solve(value);
        }

        /// <summary>The explicit cast from <see cref="Tuple{Single, Single}"/> to <see cref="SingleFraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator SingleFraction((Single numerator, Single denominator) v) {
            return new SingleFraction(v.numerator, v.denominator);
        }        

        /// <summary>The explicit cast from <see cref="IFraction{Single}"/> to <see cref="SingleFraction"/></summary>
        /// <param name="value">The object to cast</param>
        /// <returns>A <see cref="SingleFraction"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator SingleFraction(IFraction<Single> v) {
            return new SingleFraction(v.Numerator, v.Denominator);
        }
    }
}
