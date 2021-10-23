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
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16Fraction B) {
            return new UInt16Fraction((UInt16)(A.Numerator * B.Numerator), (UInt16)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16 B) {
            return new UInt16Fraction((UInt16)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Addition(UInt16Fraction A, UInt16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt16Fraction((UInt16)(A.Numerator + B.Numerator), A.Denominator);
            }

            UInt16 denominator = (UInt16)(A.Denominator * B.Denominator);
            UInt16 numeratorA = (UInt16)(A.Numerator * B.Denominator);
            UInt16 numeratorB = (UInt16)(B.Numerator * A.Denominator);
            
            return new UInt16Fraction((UInt16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Addition(UInt16Fraction A, UInt16 B) {
            if (A.Denominator == 1) {
                return new UInt16Fraction((UInt16)(A.Numerator + B), A.Denominator);
            }

            UInt16 denominator = A.Denominator; //* 1
            UInt16 numeratorA = A.Numerator; //* 1
            UInt16 numeratorB = (UInt16)(B * A.Denominator);
            
            return new UInt16Fraction((UInt16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Substract(UInt16Fraction A, UInt16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt16Fraction((UInt16)(A.Numerator - B.Numerator), A.Denominator);
            }

            UInt16 denominator = (UInt16)(A.Denominator * B.Denominator);
            UInt16 numeratorA = (UInt16)(A.Numerator * B.Denominator);
            UInt16 numeratorB = (UInt16)(B.Numerator * A.Denominator);
            
            return new UInt16Fraction((UInt16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Substract(UInt16Fraction A, UInt16 B) {
            if (A.Denominator == 1) {
                return new UInt16Fraction((UInt16)(A.Numerator - B), 1);
            }

            UInt16 denominator = A.Denominator; //* 1
            UInt16 numeratorA = A.Numerator; //* 1
            UInt16 numeratorB = (UInt16)(B * A.Denominator);
            
            return new UInt16Fraction((UInt16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A UInt16Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Pow(UInt16Fraction A, UInt16 power) {
            return new UInt16Fraction((UInt16)System.Math.Pow(A.Numerator, power) , (UInt16)System.Math.Pow(A.Denominator, power));
        }
    }
}
