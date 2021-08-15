/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using DaanV2.Math.Fractions;

namespace DaanV2.Math {
    public static partial class Math {
        /// <summary>Solves the fraction</summary>
        /// <param name="Fraction"></param>
        /// <returns></returns>
        public static %Type% Solve(%Type%Fraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type%Fraction B) {
            return new %Type%Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type% B) {
            return new %Type%Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Addition(%Type%Fraction A, %Type%Fraction B) {
            if (A.denominator == B.denominator) {
                return new %Type%Fraction(A.numerator + B.numerator, A.denominator);
            }

            %Type% denominator = A.denominator * B.denominator;
            %Type% numeratorA = A.numerator * B.denominator;
            %Type% numeratorB = B.numerator * A.denominator;
            
            return new %Type%Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Addition(%Type%Fraction A, %Type% B) {
            if (A.denominator == 1) {
                return new %Type%Fraction(A.numerator + B.numerator, A.denominator);
            }

            %Type% denominator = A.denominator; //* 1
            %Type% numeratorA = A.numerator; //* 1
            %Type% numeratorB = B * A.denominator;
            
            return new %Type%Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Substract(%Type%Fraction A, %Type%Fraction B) {
            if (A.denominator == B.denominator) {
                return new %Type%Fraction(A.numerator - B.numerator, A.denominator);
            }

            %Type% denominator = A.denominator * B.denominator;
            %Type% numeratorA = A.numerator * B.denominator;
            %Type% numeratorB = B.numerator * A.denominator;
            
            return new %Type%Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Substract(%Type%Fraction A, %Type% B) {
            if (A.denominator == B.denominator) {
                return new %Type%Fraction(A.numerator - B.numerator, A.denominator);
            }

            %Type% denominator = A.denominator; //* 1
            %Type% numeratorA = A.numerato; //* 1
            %Type% numeratorB = B * A.denominator;
            
            return new %Type%Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Inverse(%Type%Fraction A) {
            return new %Type%Fraction(A.denominator, A.numerator)
        }
    }
}
