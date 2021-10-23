/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using DaanV2.Math.Fractions;
using System.Runtime.CompilerServices;

namespace DaanV2.Math {
    public static partial class Math {
        /// <summary>Solves the fraction into a single value</summary>
        /// <param name="Fraction"></param>
        /// <returns>The value of the fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Solve(UInt16Fraction Fraction) {
            return (UInt16)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16Fraction B) {
            return new UInt16Fraction((UInt16)(A.Numerator * B.Numerator), (UInt16)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16 B) {
            return new UInt16Fraction((UInt16)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Substract(UInt16Fraction A, UInt16 B) {
            if (A.Denominator == 1) {
                return new UInt16Fraction((UInt16)(A.Numerator - B), A.Denominator);
            }

            UInt16 denominator = A.Denominator; //* 1
            UInt16 numeratorA = A.Numerator; //* 1
            UInt16 numeratorB = (UInt16)(B * A.Denominator);
            
            return new UInt16Fraction((UInt16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16Fraction Inverse(UInt16Fraction A) {
            return new UInt16Fraction(A.Denominator, A.Numerator);
        }
    }
}
