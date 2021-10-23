/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaanV2.Math.Fractions;

namespace UnitTest {
    public partial class Math {
        [TestMethod]
        public void UInt16_Simplfy() {
            var example = new UInt16Fraction(200, 150);
            var simp = DaanV2.Math.Math.Simplfy(example);

            Assert.AreEqual(simp.Numerator, (UInt16)4);
            Assert.AreEqual(simp.Denominator, (UInt16)3);
        }

    }
}
