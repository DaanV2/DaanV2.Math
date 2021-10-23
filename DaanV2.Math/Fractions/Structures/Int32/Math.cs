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
        public static Int32 Solve(Int32Fraction Fraction) {
            return (Int32)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Multiply(Int32Fraction A, Int32Fraction B) {
            return new Int32Fraction((Int32)(A.Numerator * B.Numerator), (Int32)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Multiply(Int32Fraction A, Int32 B) {
            return new Int32Fraction((Int32)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Addition(Int32Fraction A, Int32Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int32Fraction((Int32)(A.Numerator + B.Numerator), A.Denominator);
            }

            Int32 denominator = (Int32)(A.Denominator * B.Denominator);
            Int32 numeratorA = (Int32)(A.Numerator * B.Denominator);
            Int32 numeratorB = (Int32)(B.Numerator * A.Denominator);
            
            return new Int32Fraction((Int32)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Addition(Int32Fraction A, Int32 B) {
            if (A.Denominator == 1) {
                return new Int32Fraction((Int32)(A.Numerator + B), A.Denominator);
            }

            Int32 denominator = A.Denominator; //* 1
            Int32 numeratorA = A.Numerator; //* 1
            Int32 numeratorB = (Int32)(B * A.Denominator);
            
            return new Int32Fraction((Int32)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Substract(Int32Fraction A, Int32Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int32Fraction((Int32)(A.Numerator - B.Numerator), A.Denominator);
            }

            Int32 denominator = (Int32)(A.Denominator * B.Denominator);
            Int32 numeratorA = (Int32)(A.Numerator * B.Denominator);
            Int32 numeratorB = (Int32)(B.Numerator * A.Denominator);
            
            return new Int32Fraction((Int32)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Substract(Int32Fraction A, Int32 B) {
            if (A.Denominator == 1) {
                return new Int32Fraction((Int32)(A.Numerator - B), A.Denominator);
            }

            Int32 denominator = A.Denominator; //* 1
            Int32 numeratorA = A.Numerator; //* 1
            Int32 numeratorB = (Int32)(B * A.Denominator);
            
            return new Int32Fraction((Int32)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32Fraction Inverse(Int32Fraction A) {
            return new Int32Fraction(A.Denominator, A.Numerator);
        }
    }
}
