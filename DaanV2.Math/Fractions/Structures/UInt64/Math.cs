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
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Multiply(UInt64Fraction A, UInt64Fraction B) {
            return new UInt64Fraction((UInt64)(A.Numerator * B.Numerator), (UInt64)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Multiply(UInt64Fraction A, UInt64 B) {
            return new UInt64Fraction((UInt64)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Addition(UInt64Fraction A, UInt64Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt64Fraction((UInt64)(A.Numerator + B.Numerator), A.Denominator);
            }

            UInt64 denominator = (UInt64)(A.Denominator * B.Denominator);
            UInt64 numeratorA = (UInt64)(A.Numerator * B.Denominator);
            UInt64 numeratorB = (UInt64)(B.Numerator * A.Denominator);
            
            return new UInt64Fraction((UInt64)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Addition(UInt64Fraction A, UInt64 B) {
            if (A.Denominator == 1) {
                return new UInt64Fraction((UInt64)(A.Numerator + B), A.Denominator);
            }

            UInt64 denominator = A.Denominator; //* 1
            UInt64 numeratorA = A.Numerator; //* 1
            UInt64 numeratorB = (UInt64)(B * A.Denominator);
            
            return new UInt64Fraction((UInt64)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Substract(UInt64Fraction A, UInt64Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt64Fraction((UInt64)(A.Numerator - B.Numerator), A.Denominator);
            }

            UInt64 denominator = (UInt64)(A.Denominator * B.Denominator);
            UInt64 numeratorA = (UInt64)(A.Numerator * B.Denominator);
            UInt64 numeratorB = (UInt64)(B.Numerator * A.Denominator);
            
            return new UInt64Fraction((UInt64)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Substract(UInt64Fraction A, UInt64 B) {
            if (A.Denominator == 1) {
                return new UInt64Fraction((UInt64)(A.Numerator - B), 1);
            }

            UInt64 denominator = A.Denominator; //* 1
            UInt64 numeratorA = A.Numerator; //* 1
            UInt64 numeratorB = (UInt64)(B * A.Denominator);
            
            return new UInt64Fraction((UInt64)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A UInt64Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64Fraction Pow(UInt64Fraction A, UInt64 power) {
            return new UInt64Fraction((UInt64)System.Math.Pow(A.Numerator, power) , (UInt64)System.Math.Pow(A.Denominator, power));
        }
    }
}
