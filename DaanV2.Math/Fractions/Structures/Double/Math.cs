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
        public static Double Solve(DoubleFraction Fraction) {
            return (Double)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Multiply(DoubleFraction A, DoubleFraction B) {
            return new DoubleFraction((Double)(A.Numerator * B.Numerator), (Double)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Multiply(DoubleFraction A, Double B) {
            return new DoubleFraction((Double)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Addition(DoubleFraction A, DoubleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new DoubleFraction((Double)(A.Numerator + B.Numerator), A.Denominator);
            }

            Double denominator = (Double)(A.Denominator * B.Denominator);
            Double numeratorA = (Double)(A.Numerator * B.Denominator);
            Double numeratorB = (Double)(B.Numerator * A.Denominator);
            
            return new DoubleFraction((Double)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Addition(DoubleFraction A, Double B) {
            if (A.Denominator == 1) {
                return new DoubleFraction((Double)(A.Numerator + B), A.Denominator);
            }

            Double denominator = A.Denominator; //* 1
            Double numeratorA = A.Numerator; //* 1
            Double numeratorB = (Double)(B * A.Denominator);
            
            return new DoubleFraction((Double)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Substract(DoubleFraction A, DoubleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new DoubleFraction((Double)(A.Numerator - B.Numerator), A.Denominator);
            }

            Double denominator = (Double)(A.Denominator * B.Denominator);
            Double numeratorA = (Double)(A.Numerator * B.Denominator);
            Double numeratorB = (Double)(B.Numerator * A.Denominator);
            
            return new DoubleFraction((Double)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Substract(DoubleFraction A, Double B) {
            if (A.Denominator == 1) {
                return new DoubleFraction((Double)(A.Numerator - B), A.Denominator);
            }

            Double denominator = A.Denominator; //* 1
            Double numeratorA = A.Numerator; //* 1
            Double numeratorB = (Double)(B * A.Denominator);
            
            return new DoubleFraction((Double)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Inverse(DoubleFraction A) {
            return new DoubleFraction(A.Denominator, A.Numerator);
        }
    }
}
