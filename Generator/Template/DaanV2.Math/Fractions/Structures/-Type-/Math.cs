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
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type%Fraction B) {
            return new %Type%Fraction((%Type%)(A.Numerator * B.Numerator), (%Type%)(A.Denominator * B.Denominator));
        }

        /// <summary>Preforms the multiplication operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type% B) {
            return new %Type%Fraction((%Type%)(A.Numerator * B), A.Denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Addition(%Type%Fraction A, %Type%Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new %Type%Fraction((%Type%)(A.Numerator + B.Numerator), A.Denominator);
            }

            %Type% denominator = (%Type%)(A.Denominator * B.Denominator);
            %Type% numeratorA = (%Type%)(A.Numerator * B.Denominator);
            %Type% numeratorB = (%Type%)(B.Numerator * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the addition operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Addition(%Type%Fraction A, %Type% B) {
            if (A.Denominator == 1) {
                return new %Type%Fraction((%Type%)(A.Numerator + B), A.Denominator);
            }

            %Type% denominator = A.Denominator; //* 1
            %Type% numeratorA = A.Numerator; //* 1
            %Type% numeratorB = (%Type%)(B * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA + numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Substract(%Type%Fraction A, %Type%Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new %Type%Fraction((%Type%)(A.Numerator - B.Numerator), A.Denominator);
            }

            %Type% denominator = (%Type%)(A.Denominator * B.Denominator);
            %Type% numeratorA = (%Type%)(A.Numerator * B.Denominator);
            %Type% numeratorB = (%Type%)(B.Numerator * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the substract operation on the given fractions</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Substract(%Type%Fraction A, %Type% B) {
            if (A.Denominator == 1) {
                return new %Type%Fraction((%Type%)(A.Numerator - B), 1);
            }

            %Type% denominator = A.Denominator; //* 1
            %Type% numeratorA = A.Numerator; //* 1
            %Type% numeratorB = (%Type%)(B * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA - numeratorB), denominator);
        }

        /// <summary>Preforms the power operation on the given fraction</summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="power">The power to raise the fraction to</param>
        /// <returns>A %Type%Fraction</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static %Type%Fraction Pow(%Type%Fraction A, %Type% power) {
            return new %Type%Fraction((%Type%)System.Math.Pow(A.Numerator, power) , (%Type%)System.Math.Pow(A.Denominator, power));
        }
    }
}
