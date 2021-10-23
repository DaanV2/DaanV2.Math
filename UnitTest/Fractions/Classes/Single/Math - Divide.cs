/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void Single_Test_Divide(Single numA, Single numB, Single denA, Single denB, DaanV2.Math.Fractions.SingleFraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void Single_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.SingleFraction.MaxValue, UnitTest.Fractions.SingleFraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.SingleFraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.SingleFraction.MinValue);
        }

        [TestMethod]
        public void Single_Divide2() {
            var A = new DaanV2.Math.Fractions.SingleFraction(5, 13);
            var B = new DaanV2.Math.Fractions.SingleFraction(7, 9);

            var C = A / B;

            Single_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void Single_Divide3() {
            var A = new DaanV2.Math.Fractions.SingleFraction(5, 13);

            const Single den = 2;
            DaanV2.Math.Fractions.SingleFraction C = A / den;

            Single_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void Single_Divide4() {
            var A = new DaanV2.Math.Fractions.SingleFraction(5, 13);

            const Single den = 2;
            DaanV2.Math.Fractions.SingleFraction C = den / A;

            Single_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
