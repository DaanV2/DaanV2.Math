/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaanV2.Math.Fractions;

namespace UnitTest {
    public partial class Math {
        [TestMethod]
        public void Int64_Simplfy() {
            var example = new Int64Fraction(200, 150);
            var simp = DaanV2.Math.Math.Simplfy(example);

            Assert.AreEqual(example.Numerator, 4);
            Assert.AreEqual(example.Denominator, 3);
        }

    }
}
