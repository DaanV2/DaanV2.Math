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
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Multiply(UInt32Fraction A, UInt32Fraction B) {
            return new UInt32Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Multiply(UInt32Fraction A, UInt32 B) {
            return new UInt32Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Addition(UInt32Fraction A, UInt32Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt32Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt32 denominator = A.denominator * B.denominator;
            UInt32 numeratorA = A.numerator * B.denominator;
            UInt32 numeratorB = B.numerator * A.denominator;
            
            return new UInt32Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Addition(UInt32Fraction A, UInt32 B) {
            if (A.denominator == 1) {
                return new UInt32Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt32 denominator = A.denominator; //* 1
            UInt32 numeratorA = A.numerator; //* 1
            UInt32 numeratorB = B * A.denominator;
            
            return new UInt32Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Substract(UInt32Fraction A, UInt32Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt32Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt32 denominator = A.denominator * B.denominator;
            UInt32 numeratorA = A.numerator * B.denominator;
            UInt32 numeratorB = B.numerator * A.denominator;
            
            return new UInt32Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Substract(UInt32Fraction A, UInt32 B) {
            if (A.denominator == B.denominator) {
                return new UInt32Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt32 denominator = A.denominator; //* 1
            UInt32 numeratorA = A.numerato; //* 1
            UInt32 numeratorB = B * A.denominator;
            
            return new UInt32Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt32Fraction Inverse(UInt32Fraction A) {
            return new UInt32Fraction(A.denominator, A.numerator)
        }
    }
}
