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
        public static Int16 Solve(Int16Fraction Fraction) {
            return (Int16)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Multiply(Int16Fraction A, Int16Fraction B) {
            return new Int16Fraction((Int16)(A.Numerator * B.Numerator), (Int16)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Multiply(Int16Fraction A, Int16 B) {
            return new Int16Fraction((Int16)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Addition(Int16Fraction A, Int16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int16Fraction((Int16)(A.Numerator + B.Numerator), A.Denominator);
            }

            Int16 denominator = (Int16)(A.Denominator * B.Denominator);
            Int16 numeratorA = (Int16)(A.Numerator * B.Denominator);
            Int16 numeratorB = (Int16)(B.Numerator * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Addition(Int16Fraction A, Int16 B) {
            if (A.Denominator == 1) {
                return new Int16Fraction((Int16)(A.Numerator + B), A.Denominator);
            }

            Int16 denominator = A.Denominator; //* 1
            Int16 numeratorA = A.Numerator; //* 1
            Int16 numeratorB = (Int16)(B * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Substract(Int16Fraction A, Int16Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new Int16Fraction((Int16)(A.Numerator - B.Numerator), A.Denominator);
            }

            Int16 denominator = (Int16)(A.Denominator * B.Denominator);
            Int16 numeratorA = (Int16)(A.Numerator * B.Denominator);
            Int16 numeratorB = (Int16)(B.Numerator * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Substract(Int16Fraction A, Int16 B) {
            if (A.Denominator == 1) {
                return new Int16Fraction((Int16)(A.Numerator - B), A.Denominator);
            }

            Int16 denominator = A.Denominator; //* 1
            Int16 numeratorA = A.Numerator; //* 1
            Int16 numeratorB = (Int16)(B * A.Denominator);
            
            return new Int16Fraction((Int16)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static Int16Fraction Inverse(Int16Fraction A) {
            return new Int16Fraction(A.Denominator, A.Numerator);
        }
    }
}
