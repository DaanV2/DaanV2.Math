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
        public static Single Solve(SingleFraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Multiply(SingleFraction A, SingleFraction B) {
            return new SingleFraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Multiply(SingleFraction A, Single B) {
            return new SingleFraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Addition(SingleFraction A, SingleFraction B) {
            if (A.denominator == B.denominator) {
                return new SingleFraction(A.numerator + B.numerator, A.denominator);
            }

            Single denominator = A.denominator * B.denominator;
            Single numeratorA = A.numerator * B.denominator;
            Single numeratorB = B.numerator * A.denominator;
            
            return new SingleFraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Addition(SingleFraction A, Single B) {
            if (A.denominator == 1) {
                return new SingleFraction(A.numerator + B.numerator, A.denominator);
            }

            Single denominator = A.denominator; //* 1
            Single numeratorA = A.numerator; //* 1
            Single numeratorB = B * A.denominator;
            
            return new SingleFraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Substract(SingleFraction A, SingleFraction B) {
            if (A.denominator == B.denominator) {
                return new SingleFraction(A.numerator - B.numerator, A.denominator);
            }

            Single denominator = A.denominator * B.denominator;
            Single numeratorA = A.numerator * B.denominator;
            Single numeratorB = B.numerator * A.denominator;
            
            return new SingleFraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Substract(SingleFraction A, Single B) {
            if (A.denominator == B.denominator) {
                return new SingleFraction(A.numerator - B.numerator, A.denominator);
            }

            Single denominator = A.denominator; //* 1
            Single numeratorA = A.numerato; //* 1
            Single numeratorB = B * A.denominator;
            
            return new SingleFraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SingleFraction Inverse(SingleFraction A) {
            return new SingleFraction(A.denominator, A.numerator)
        }
    }
}
