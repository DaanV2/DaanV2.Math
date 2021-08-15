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
        public static Int64 Solve(Int64Fraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Multiply(Int64Fraction A, Int64Fraction B) {
            return new Int64Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Multiply(Int64Fraction A, Int64 B) {
            return new Int64Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Addition(Int64Fraction A, Int64Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int64Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int64 denominator = A.denominator * B.denominator;
            Int64 numeratorA = A.numerator * B.denominator;
            Int64 numeratorB = B.numerator * A.denominator;
            
            return new Int64Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Addition(Int64Fraction A, Int64 B) {
            if (A.denominator == 1) {
                return new Int64Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int64 denominator = A.denominator; //* 1
            Int64 numeratorA = A.numerator; //* 1
            Int64 numeratorB = B * A.denominator;
            
            return new Int64Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Substract(Int64Fraction A, Int64Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int64Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int64 denominator = A.denominator * B.denominator;
            Int64 numeratorA = A.numerator * B.denominator;
            Int64 numeratorB = B.numerator * A.denominator;
            
            return new Int64Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Substract(Int64Fraction A, Int64 B) {
            if (A.denominator == B.denominator) {
                return new Int64Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int64 denominator = A.denominator; //* 1
            Int64 numeratorA = A.numerato; //* 1
            Int64 numeratorB = B * A.denominator;
            
            return new Int64Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int64Fraction Inverse(Int64Fraction A) {
            return new Int64Fraction(A.denominator, A.numerator)
        }
    }
}
