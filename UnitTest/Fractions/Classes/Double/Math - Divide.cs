/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void Double_Test_Divide(Double numA, Double numB, Double denA, Double denB, DaanV2.Math.Fractions.DoubleFraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void Double_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.DoubleFraction.MaxValue, UnitTest.Fractions.DoubleFraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.DoubleFraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.DoubleFraction.MinValue);
        }

        [TestMethod]
        public void Double_Divide2() {
            var A = new DaanV2.Math.Fractions.DoubleFraction(5, 13);
            var B = new DaanV2.Math.Fractions.DoubleFraction(7, 9);

            var C = A / B;

            Double_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void Double_Divide3() {
            var A = new DaanV2.Math.Fractions.DoubleFraction(5, 13);

            const Double den = 2;
            DaanV2.Math.Fractions.DoubleFraction C = A / den;

            Double_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void Double_Divide4() {
            var A = new DaanV2.Math.Fractions.DoubleFraction(5, 13);

            const Double den = 2;
            DaanV2.Math.Fractions.DoubleFraction C = den / A;

            Double_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
