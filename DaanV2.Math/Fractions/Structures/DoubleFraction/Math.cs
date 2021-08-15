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
        public static Double Solve(DoubleFraction Fraction) {
            return Fraction.Numerator / Fraction.Denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Multiply(DoubleFraction A, DoubleFraction B) {
            return new DoubleFraction(A.numerator * B.numerator, A.denominator * B.denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Multiply(DoubleFraction A, Double B) {
            return new DoubleFraction(A.numerator * B, A.denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Addition(DoubleFraction A, DoubleFraction B) {
            if (A.denominator == B.denominator) {
                return new DoubleFraction(A.numerator + B.numerator, A.denominator);
            }

            Double denominator = A.denominator * B.denominator;
            Double numeratorA = A.numerator * B.denominator;
            Double numeratorB = B.numerator * A.denominator;
            
            return new DoubleFraction(numeratorA + numeratorB, denominator);
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Addition(DoubleFraction A, Double B) {
            if (A.denominator == 1) {
                return new DoubleFraction(A.numerator + B.numerator, A.denominator);
            }

            Double denominator = A.denominator; //* 1
            Double numeratorA = A.numerator; //* 1
            Double numeratorB = B * A.denominator;
            
            return new DoubleFraction(numeratorA + numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Substract(DoubleFraction A, DoubleFraction B) {
            if (A.denominator == B.denominator) {
                return new DoubleFraction(A.numerator - B.numerator, A.denominator);
            }

            Double denominator = A.denominator * B.denominator;
            Double numeratorA = A.numerator * B.denominator;
            Double numeratorB = B.numerator * A.denominator;
            
            return new DoubleFraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Substract(DoubleFraction A, Double B) {
            if (A.denominator == B.denominator) {
                return new DoubleFraction(A.numerator - B.numerator, A.denominator);
            }

            Double denominator = A.denominator; //* 1
            Double numeratorA = A.numerato; //* 1
            Double numeratorB = B * A.denominator;
            
            return new DoubleFraction(numeratorA - numeratorB, denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static DoubleFraction Inverse(DoubleFraction A) {
            return new DoubleFraction(A.denominator, A.numerator)
        }
    }
}
