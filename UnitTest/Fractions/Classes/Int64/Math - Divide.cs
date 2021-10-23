/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void Int64_Test_Divide(Int64 numA, Int64 numB, Int64 denA, Int64 denB, DaanV2.Math.Fractions.Int64Fraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void Int64_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.Int64Fraction.MaxValue, UnitTest.Fractions.Int64Fraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.Int64Fraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.Int64Fraction.MinValue);
        }

        [TestMethod]
        public void Int64_Divide2() {
            var A = new DaanV2.Math.Fractions.Int64Fraction(5, 13);
            var B = new DaanV2.Math.Fractions.Int64Fraction(7, 9);

            var C = A / B;

            Int64_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void Int64_Divide3() {
            var A = new DaanV2.Math.Fractions.Int64Fraction(5, 13);

            const Int64 den = 2;
            DaanV2.Math.Fractions.Int64Fraction C = A / den;

            Int64_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void Int64_Divide4() {
            var A = new DaanV2.Math.Fractions.Int64Fraction(5, 13);

            const Int64 den = 2;
            DaanV2.Math.Fractions.Int64Fraction C = den / A;

            Int64_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
