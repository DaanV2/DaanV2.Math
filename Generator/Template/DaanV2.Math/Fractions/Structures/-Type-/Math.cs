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
            return (%Type%)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type%Fraction B) {
            return new %Type%Fraction((%Type%)(A.Numerator * B.Numerator), (%Type%)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Multiply(%Type%Fraction A, %Type% B) {
            return new %Type%Fraction((%Type%)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Addition(%Type%Fraction A, %Type%Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new %Type%Fraction((%Type%)(A.Numerator + B.Numerator), A.Denominator);
            }

            %Type% denominator = (%Type%)(A.Denominator * B.Denominator);
            %Type% numeratorA = (%Type%)(A.Numerator * B.Denominator);
            %Type% numeratorB = (%Type%)(B.Numerator * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Addition(%Type%Fraction A, %Type% B) {
            if (A.Denominator == 1) {
                return new %Type%Fraction((%Type%)(A.Numerator + B), A.Denominator);
            }

            %Type% denominator = A.Denominator; //* 1
            %Type% numeratorA = A.Numerator; //* 1
            %Type% numeratorB = (%Type%)(B * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Substract(%Type%Fraction A, %Type%Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new %Type%Fraction((%Type%)(A.Numerator - B.Numerator), A.Denominator);
            }

            %Type% denominator = (%Type%)(A.Denominator * B.Denominator);
            %Type% numeratorA = (%Type%)(A.Numerator * B.Denominator);
            %Type% numeratorB = (%Type%)(B.Numerator * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Substract(%Type%Fraction A, %Type% B) {
            if (A.Denominator == 1) {
                return new %Type%Fraction((%Type%)(A.Numerator - B), A.Denominator);
            }

            %Type% denominator = A.Denominator; //* 1
            %Type% numeratorA = A.Numerator; //* 1
            %Type% numeratorB = (%Type%)(B * A.Denominator);
            
            return new %Type%Fraction((%Type%)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static %Type%Fraction Inverse(%Type%Fraction A) {
            return new %Type%Fraction(A.Denominator, A.Numerator);
        }
    }
}
