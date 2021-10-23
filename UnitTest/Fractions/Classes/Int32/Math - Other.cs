/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaanV2.Math.Fractions;

namespace UnitTest {
    public partial class Math {
        [TestMethod]
        public void Int32_Simplfy() {
            var example = new Int32Fraction(200, 150);
            var simp = DaanV2.Math.Math.Simplfy(example);

            Assert.AreEqual(simp.Numerator, (Int32)4);
            Assert.AreEqual(simp.Denominator, (Int32)3);
        }

    }
}
