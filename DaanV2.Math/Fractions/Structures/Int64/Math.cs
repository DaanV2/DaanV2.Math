/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using DaanV2.Math.Fractions;
using System.Runtime.CompilerServices;

namespace DaanV2.Math {
    public static partial class Math {
        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Multiply(Int64Fraction A, Int64Fraction B) {
            return new Int64Fraction((Int64)(A.Numerator * B.Numerator), (Int64)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Multiply(Int64Fraction A, Int64 B) {
            return new Int64Fraction((Int64)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Addition(Int64Fraction A, Int64Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int64Fraction((Int64)(A.Numerator + B.Numerator), A.Denominator);
            }

            Int64 denominator = (Int64)(A.Denominator * B.Denominator);
            Int64 numeratorA = (Int64)(A.Numerator * B.Denominator);
            Int64 numeratorB = (Int64)(B.Numerator * A.Denominator);
            
            return new Int64Fraction((Int64)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Addition(Int64Fraction A, Int64 B) {
            if (A.Denominator == 1) {
                return new Int64Fraction((Int64)(A.Numerator + B), A.Denominator);
            }

            Int64 denominator = A.Denominator; //* 1
            Int64 numeratorA = A.Numerator; //* 1
            Int64 numeratorB = (Int64)(B * A.Denominator);
            
            return new Int64Fraction((Int64)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Substract(Int64Fraction A, Int64Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int64Fraction((Int64)(A.Numerator - B.Numerator), A.Denominator);
            }

            Int64 denominator = (Int64)(A.Denominator * B.Denominator);
            Int64 numeratorA = (Int64)(A.Numerator * B.Denominator);
            Int64 numeratorB = (Int64)(B.Numerator * A.Denominator);
            
            return new Int64Fraction((Int64)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Substract(Int64Fraction A, Int64 B) {
            if (A.Denominator == 1) {
                return new Int64Fraction((Int64)(A.Numerator - B), 1);
            }

            Int64 denominator = A.Denominator; //* 1
            Int64 numeratorA = A.Numerator; //* 1
            Int64 numeratorB = (Int64)(B * A.Denominator);
            
            return new Int64Fraction((Int64)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A Int64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64Fraction Pow(Int64Fraction A, Int64 power) {
            return new Int64Fraction((Int64)System.Math.Pow(A.Numerator, power) , (Int64)System.Math.Pow(A.Denominator, power));
        }
    }
}
