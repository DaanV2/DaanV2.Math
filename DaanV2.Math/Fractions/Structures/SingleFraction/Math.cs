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
            return (Single)(Fraction.Numerator / Fraction.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Multiply(SingleFraction A, SingleFraction B) {
            return new SingleFraction((Single)(A.Numerator * B.Numerator), (Single)(A.Denominator * B.Denominator));
        }

                /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Multiply(SingleFraction A, Single B) {
            return new SingleFraction((Single)(A.Numerator * B), A.Denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Addition(SingleFraction A, SingleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new SingleFraction((Single)(A.Numerator + B.Numerator), A.Denominator);
            }

            Single denominator = (Single)(A.Denominator * B.Denominator);
            Single numeratorA = (Single)(A.Numerator * B.Denominator);
            Single numeratorB = (Single)(B.Numerator * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Addition(SingleFraction A, Single B) {
            if (A.Denominator == 1) {
                return new SingleFraction((Single)(A.Numerator + B), A.Denominator);
            }

            Single denominator = A.Denominator; //* 1
            Single numeratorA = A.Numerator; //* 1
            Single numeratorB = (Single)(B * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA + numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Substract(SingleFraction A, SingleFraction B) {
            if (A.Denominator == B.Denominator) {
                return new SingleFraction((Single)(A.Numerator - B.Numerator), A.Denominator);
            }

            Single denominator = (Single)(A.Denominator * B.Denominator);
            Single numeratorA = (Single)(A.Numerator * B.Denominator);
            Single numeratorB = (Single)(B.Numerator * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Substract(SingleFraction A, Single B) {
            if (A.Denominator == 1) {
                return new SingleFraction((Single)(A.Numerator - B), A.Denominator);
            }

            Single denominator = A.Denominator; //* 1
            Single numeratorA = A.Numerator; //* 1
            Single numeratorB = (Single)(B * A.Denominator);
            
            return new SingleFraction((Single)(numeratorA - numeratorB), denominator);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">The first value in the operation</param>
        /// <param name="B">The second value in the operation</param>
        /// <returns></returns>
        public static SingleFraction Inverse(SingleFraction A) {
            return new SingleFraction(A.Denominator, A.Numerator);
        }
    }
}
