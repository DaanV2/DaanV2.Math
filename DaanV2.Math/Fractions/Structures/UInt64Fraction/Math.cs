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
        public static UInt64 Solve(UInt64Fraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Multiply(UInt64Fraction A, UInt64Fraction B) {
            return new UInt64Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Multiply(UInt64Fraction A, UInt64 B) {
            return new UInt64Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Addition(UInt64Fraction A, UInt64Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt64Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt64 denominator = A.denominator * B.denominator;
            UInt64 numeratorA = A.numerator * B.denominator;
            UInt64 numeratorB = B.numerator * A.denominator;
            
            return new UInt64Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Addition(UInt64Fraction A, UInt64 B) {
            if (A.denominator == 1) {
                return new UInt64Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt64 denominator = A.denominator; //* 1
            UInt64 numeratorA = A.numerator; //* 1
            UInt64 numeratorB = B * A.denominator;
            
            return new UInt64Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Substract(UInt64Fraction A, UInt64Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt64Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt64 denominator = A.denominator * B.denominator;
            UInt64 numeratorA = A.numerator * B.denominator;
            UInt64 numeratorB = B.numerator * A.denominator;
            
            return new UInt64Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Substract(UInt64Fraction A, UInt64 B) {
            if (A.denominator == B.denominator) {
                return new UInt64Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt64 denominator = A.denominator; //* 1
            UInt64 numeratorA = A.numerato; //* 1
            UInt64 numeratorB = B * A.denominator;
            
            return new UInt64Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt64Fraction Inverse(UInt64Fraction A) {
            return new UInt64Fraction(A.denominator, A.numerator)
        }
    }
}
