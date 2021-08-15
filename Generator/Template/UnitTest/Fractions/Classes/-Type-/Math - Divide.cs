/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    public partial class Math {
        public void %Type%_Test_Divide(%Type% numA, %Type% numB, %Type% denA, %Type% denB, DaanV2.Math.Fractions.%Type%Fraction frac) {
            Double numR = (Double)(numA * denB);
            Double denR = (Double)(denA * numB);

            Assert.AreEqual(frac.Numerator, numR, $"expected: {frac.Numerator} = {numA} x {denB} but is: {numR}");
            Assert.AreEqual(frac.Denominator, denR, $"expected: {frac.Denominator} = {denA} x {numB} but is: {denR}");
        }

        [TestMethod]
        public void %Type%_Divide1() {
            var Temp = DaanV2.Math.Math.Divide(UnitTest.Fractions.%Type%Fraction.MaxValue, UnitTest.Fractions.%Type%Fraction.MinValue);

            Assert.AreEqual(Temp.Numerator, UnitTest.Fractions.%Type%Fraction.MaxValue);
            Assert.AreEqual(Temp.Denominator, UnitTest.Fractions.%Type%Fraction.MinValue);
        }

        [TestMethod]
        public void %Type%_Divide2() {
            var A = new DaanV2.Math.Fractions.%Type%Fraction(5, 13);
            var B = new DaanV2.Math.Fractions.%Type%Fraction(7, 9);

            var C = A / B;

            %Type%_Test_Divide(5, 7, 13, 9, C);
        }

        [TestMethod]
        public void %Type%_Divide3() {
            var A = new DaanV2.Math.Fractions.%Type%Fraction(5, 13);

            const %Type% den = 2;
            DaanV2.Math.Fractions.%Type%Fraction C = A / den;

            %Type%_Test_Divide(5, 2, 13, 1, C);
        }

        [TestMethod]
        public void %Type%_Divide4() {
            var A = new DaanV2.Math.Fractions.%Type%Fraction(5, 13);

            const %Type% den = 2;
            DaanV2.Math.Fractions.%Type%Fraction C = den / A;

            %Type%_Test_Divide(2, 5, 1, 13, C);
        }
    }
}
