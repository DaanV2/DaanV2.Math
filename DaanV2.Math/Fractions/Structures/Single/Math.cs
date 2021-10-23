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
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Multiply(SingleFraction A, SingleFraction B) {
            return new SingleFraction((Single)(A.Numerator * B.Numerator), (Single)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Multiply(SingleFraction A, Single B) {
            return new SingleFraction((Single)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Addition(SingleFraction A, SingleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new SingleFraction((Single)(A.Numerator + B.Numerator), A.Denominator);
            }

            Single denominator = (Single)(A.Denominator * B.Denominator);
            Single numeratorA = (Single)(A.Numerator * B.Denominator);
            Single numeratorB = (Single)(B.Numerator * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Addition(SingleFraction A, Single B) {
            if (A.Denominator == 1) {
                return new SingleFraction((Single)(A.Numerator + B), A.Denominator);
            }

            Single denominator = A.Denominator; //* 1
            Single numeratorA = A.Numerator; //* 1
            Single numeratorB = (Single)(B * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Substract(SingleFraction A, SingleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new SingleFraction((Single)(A.Numerator - B.Numerator), A.Denominator);
            }

            Single denominator = (Single)(A.Denominator * B.Denominator);
            Single numeratorA = (Single)(A.Numerator * B.Denominator);
            Single numeratorB = (Single)(B.Numerator * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Substract(SingleFraction A, Single B) {
            if (A.Denominator == 1) {
                return new SingleFraction((Single)(A.Numerator - B), 1);
            }

            Single denominator = A.Denominator; //* 1
            Single numeratorA = A.Numerator; //* 1
            Single numeratorB = (Single)(B * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A SingleFraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SingleFraction Pow(SingleFraction A, Single power) {
            return new SingleFraction((Single)System.Math.Pow(A.Numerator, power) , (Single)System.Math.Pow(A.Denominator, power));
        }
    }
}
