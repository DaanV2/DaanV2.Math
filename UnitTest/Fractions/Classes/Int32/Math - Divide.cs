/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void Int32_Test_Divide(Int32 numA, Int32 numB, Int32 denA, Int32 denB, DaanV2.Math.Fractions.Int32Fraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void Int32_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.Int32Fraction.MaxValue, UnitTest.Fractions.Int32Fraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.Int32Fraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.Int32Fraction.MinValue);
        }

        [TestMethod]
        public void Int32_Divide2() {
            var A = new DaanV2.Math.Fractions.Int32Fraction(5, 13);
            var B = new DaanV2.Math.Fractions.Int32Fraction(7, 9);

            var C = A / B;

            Int32_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void Int32_Divide3() {
            var A = new DaanV2.Math.Fractions.Int32Fraction(5, 13);

            const Int32 den = 2;
            DaanV2.Math.Fractions.Int32Fraction C = A / den;

            Int32_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void Int32_Divide4() {
            var A = new DaanV2.Math.Fractions.Int32Fraction(5, 13);

            const Int32 den = 2;
            DaanV2.Math.Fractions.Int32Fraction C = den / A;

            Int32_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
