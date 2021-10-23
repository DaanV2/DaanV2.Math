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
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Multiply(DoubleFraction A, DoubleFraction B) {
            return new DoubleFraction((Double)(A.Numerator * B.Numerator), (Double)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Multiply(DoubleFraction A, Double B) {
            return new DoubleFraction((Double)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
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

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
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

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
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

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Substract(DoubleFraction A, Double B) {
            if (A.Denominator == 1) {
                return new DoubleFraction((Double)(A.Numerator - B), 1);
            }

            Double denominator = A.Denominator; //* 1
            Double numeratorA = A.Numerator; //* 1
            Double numeratorB = (Double)(B * A.Denominator);
            
            return new DoubleFraction((Double)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A DoubleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DoubleFraction Pow(DoubleFraction A, Double power) {
            return new DoubleFraction((Double)System.Math.Pow(A.Numerator, power) , (Double)System.Math.Pow(A.Denominator, power));
        }
    }
}
