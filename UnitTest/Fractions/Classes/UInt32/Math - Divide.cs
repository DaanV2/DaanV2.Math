/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void UInt32_Test_Divide(UInt32 numA, UInt32 numB, UInt32 denA, UInt32 denB, DaanV2.Math.Fractions.UInt32Fraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void UInt32_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.UInt32Fraction.MaxValue, UnitTest.Fractions.UInt32Fraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.UInt32Fraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.UInt32Fraction.MinValue);
        }

        [TestMethod]
        public void UInt32_Divide2() {
            var A = new DaanV2.Math.Fractions.UInt32Fraction(5, 13);
            var B = new DaanV2.Math.Fractions.UInt32Fraction(7, 9);

            var C = A / B;

            UInt32_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void UInt32_Divide3() {
            var A = new DaanV2.Math.Fractions.UInt32Fraction(5, 13);

            const UInt32 den = 2;
            DaanV2.Math.Fractions.UInt32Fraction C = A / den;

            UInt32_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void UInt32_Divide4() {
            var A = new DaanV2.Math.Fractions.UInt32Fraction(5, 13);

            const UInt32 den = 2;
            DaanV2.Math.Fractions.UInt32Fraction C = den / A;

            UInt32_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
