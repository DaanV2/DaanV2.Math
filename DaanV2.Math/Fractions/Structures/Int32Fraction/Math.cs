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
        public static Int32 Solve(Int32Fraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Multiply(Int32Fraction A, Int32Fraction B) {
            return new Int32Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Multiply(Int32Fraction A, Int32 B) {
            return new Int32Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Addition(Int32Fraction A, Int32Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int32Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int32 denominator = A.denominator * B.denominator;
            Int32 numeratorA = A.numerator * B.denominator;
            Int32 numeratorB = B.numerator * A.denominator;
            
            return new Int32Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Addition(Int32Fraction A, Int32 B) {
            if (A.denominator == 1) {
                return new Int32Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int32 denominator = A.denominator; //* 1
            Int32 numeratorA = A.numerator; //* 1
            Int32 numeratorB = B * A.denominator;
            
            return new Int32Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Substract(Int32Fraction A, Int32Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int32Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int32 denominator = A.denominator * B.denominator;
            Int32 numeratorA = A.numerator * B.denominator;
            Int32 numeratorB = B.numerator * A.denominator;
            
            return new Int32Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Substract(Int32Fraction A, Int32 B) {
            if (A.denominator == B.denominator) {
                return new Int32Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int32 denominator = A.denominator; //* 1
            Int32 numeratorA = A.numerato; //* 1
            Int32 numeratorB = B * A.denominator;
            
            return new Int32Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int32Fraction Inverse(Int32Fraction A) {
            return new Int32Fraction(A.denominator, A.numerator)
        }
    }
}
