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
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Multiply(Int16Fraction A, Int16Fraction B) {
            return new Int16Fraction((Int16)(A.Numerator * B.Numerator), (Int16)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Multiply(Int16Fraction A, Int16 B) {
            return new Int16Fraction((Int16)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Addition(Int16Fraction A, Int16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int16Fraction((Int16)(A.Numerator + B.Numerator), A.Denominator);
            }

            Int16 denominator = (Int16)(A.Denominator * B.Denominator);
            Int16 numeratorA = (Int16)(A.Numerator * B.Denominator);
            Int16 numeratorB = (Int16)(B.Numerator * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Addition(Int16Fraction A, Int16 B) {
            if (A.Denominator == 1) {
                return new Int16Fraction((Int16)(A.Numerator + B), A.Denominator);
            }

            Int16 denominator = A.Denominator; //* 1
            Int16 numeratorA = A.Numerator; //* 1
            Int16 numeratorB = (Int16)(B * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Substract(Int16Fraction A, Int16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int16Fraction((Int16)(A.Numerator - B.Numerator), A.Denominator);
            }

            Int16 denominator = (Int16)(A.Denominator * B.Denominator);
            Int16 numeratorA = (Int16)(A.Numerator * B.Denominator);
            Int16 numeratorB = (Int16)(B.Numerator * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Substract(Int16Fraction A, Int16 B) {
            if (A.Denominator == 1) {
                return new Int16Fraction((Int16)(A.Numerator - B), 1);
            }

            Int16 denominator = A.Denominator; //* 1
            Int16 numeratorA = A.Numerator; //* 1
            Int16 numeratorB = (Int16)(B * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A Int16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16Fraction Pow(Int16Fraction A, Int16 power) {
            return new Int16Fraction((Int16)System.Math.Pow(A.Numerator, power) , (Int16)System.Math.Pow(A.Denominator, power));
        }
    }
}
