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
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Multiply(Int16Fraction A, Int16Fraction B) {
            return new Int16Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Multiply(Int16Fraction A, Int16 B) {
            return new Int16Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Addition(Int16Fraction A, Int16Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int16Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int16 denominator = A.denominator * B.denominator;
            Int16 numeratorA = A.numerator * B.denominator;
            Int16 numeratorB = B.numerator * A.denominator;
            
            return new Int16Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Addition(Int16Fraction A, Int16 B) {
            if (A.denominator == 1) {
                return new Int16Fraction(A.numerator + B.numerator, A.denominator);
            }

            Int16 denominator = A.denominator; //* 1
            Int16 numeratorA = A.numerator; //* 1
            Int16 numeratorB = B * A.denominator;
            
            return new Int16Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Substract(Int16Fraction A, Int16Fraction B) {
            if (A.denominator == B.denominator) {
                return new Int16Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int16 denominator = A.denominator * B.denominator;
            Int16 numeratorA = A.numerator * B.denominator;
            Int16 numeratorB = B.numerator * A.denominator;
            
            return new Int16Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Substract(Int16Fraction A, Int16 B) {
            if (A.denominator == B.denominator) {
                return new Int16Fraction(A.numerator - B.numerator, A.denominator);
            }

            Int16 denominator = A.denominator; //* 1
            Int16 numeratorA = A.numerato; //* 1
            Int16 numeratorB = B * A.denominator;
            
            return new Int16Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Int16Fraction Inverse(Int16Fraction A) {
            return new Int16Fraction(A.denominator, A.numerator)
        }
    }
}
