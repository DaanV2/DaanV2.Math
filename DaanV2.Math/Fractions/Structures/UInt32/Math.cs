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
        public static UInt32 Solve(UInt32Fraction Fraction) {
            return (UInt32)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Multiply(UInt32Fraction A, UInt32Fraction B) {
            return new UInt32Fraction((UInt32)(A.Numerator * B.Numerator), (UInt32)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Multiply(UInt32Fraction A, UInt32 B) {
            return new UInt32Fraction((UInt32)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Addition(UInt32Fraction A, UInt32Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt32Fraction((UInt32)(A.Numerator + B.Numerator), A.Denominator);
            }

            UInt32 denominator = (UInt32)(A.Denominator * B.Denominator);
            UInt32 numeratorA = (UInt32)(A.Numerator * B.Denominator);
            UInt32 numeratorB = (UInt32)(B.Numerator * A.Denominator);
            
            return new UInt32Fraction((UInt32)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Addition(UInt32Fraction A, UInt32 B) {
            if (A.Denominator == 1) {
                return new UInt32Fraction((UInt32)(A.Numerator + B), A.Denominator);
            }

            UInt32 denominator = A.Denominator; //* 1
            UInt32 numeratorA = A.Numerator; //* 1
            UInt32 numeratorB = (UInt32)(B * A.Denominator);
            
            return new UInt32Fraction((UInt32)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Substract(UInt32Fraction A, UInt32Fraction B) {
            if (A.Denominator == B.Denominator) {
                return new UInt32Fraction((UInt32)(A.Numerator - B.Numerator), A.Denominator);
            }

            UInt32 denominator = (UInt32)(A.Denominator * B.Denominator);
            UInt32 numeratorA = (UInt32)(A.Numerator * B.Denominator);
            UInt32 numeratorB = (UInt32)(B.Numerator * A.Denominator);
            
            return new UInt32Fraction((UInt32)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Substract(UInt32Fraction A, UInt32 B) {
            if (A.Denominator == 1) {
                return new UInt32Fraction((UInt32)(A.Numerator - B), A.Denominator);
            }

            UInt32 denominator = A.Denominator; //* 1
            UInt32 numeratorA = A.Numerator; //* 1
            UInt32 numeratorB = (UInt32)(B * A.Denominator);
            
            return new UInt32Fraction((UInt32)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static UInt32Fraction Inverse(UInt32Fraction A) {
            return new UInt32Fraction(A.Denominator, A.Numerator);
        }
    }
}
