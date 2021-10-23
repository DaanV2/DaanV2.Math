/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void Int16_Test_Divide(Int16 numA, Int16 numB, Int16 denA, Int16 denB, DaanV2.Math.Fractions.Int16Fraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void Int16_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.Int16Fraction.MaxValue, UnitTest.Fractions.Int16Fraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.Int16Fraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.Int16Fraction.MinValue);
        }

        [TestMethod]
        public void Int16_Divide2() {
            var A = new DaanV2.Math.Fractions.Int16Fraction(5, 13);
            var B = new DaanV2.Math.Fractions.Int16Fraction(7, 9);

            var C = A / B;

            Int16_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void Int16_Divide3() {
            var A = new DaanV2.Math.Fractions.Int16Fraction(5, 13);

            const Int16 den = 2;
            DaanV2.Math.Fractions.Int16Fraction C = A / den;

            Int16_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void Int16_Divide4() {
            var A = new DaanV2.Math.Fractions.Int16Fraction(5, 13);

            const Int16 den = 2;
            DaanV2.Math.Fractions.Int16Fraction C = den / A;

            Int16_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
