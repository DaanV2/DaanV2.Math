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
        public static UInt16 Solve(UInt16Fraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16Fraction B) {
            return new UInt16Fraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Multiply(UInt16Fraction A, UInt16 B) {
            return new UInt16Fraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Addition(UInt16Fraction A, UInt16Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt16Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt16 denominator = A.denominator * B.denominator;
            UInt16 numeratorA = A.numerator * B.denominator;
            UInt16 numeratorB = B.numerator * A.denominator;
            
            return new UInt16Fraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Addition(UInt16Fraction A, UInt16 B) {
            if (A.denominator == 1) {
                return new UInt16Fraction(A.numerator + B.numerator, A.denominator);
            }

            UInt16 denominator = A.denominator; //* 1
            UInt16 numeratorA = A.numerator; //* 1
            UInt16 numeratorB = B * A.denominator;
            
            return new UInt16Fraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Substract(UInt16Fraction A, UInt16Fraction B) {
            if (A.denominator == B.denominator) {
                return new UInt16Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt16 denominator = A.denominator * B.denominator;
            UInt16 numeratorA = A.numerator * B.denominator;
            UInt16 numeratorB = B.numerator * A.denominator;
            
            return new UInt16Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Substract(UInt16Fraction A, UInt16 B) {
            if (A.denominator == B.denominator) {
                return new UInt16Fraction(A.numerator - B.numerator, A.denominator);
            }

            UInt16 denominator = A.denominator; //* 1
            UInt16 numeratorA = A.numerato; //* 1
            UInt16 numeratorB = B * A.denominator;
            
            return new UInt16Fraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static UInt16Fraction Inverse(UInt16Fraction A) {
            return new UInt16Fraction(A.denominator, A.numerator)
        }
    }
}
