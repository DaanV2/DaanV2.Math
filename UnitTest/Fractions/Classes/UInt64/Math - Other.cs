/* --------------------------------- */
/*  NOTICE: auto generated file  */
/* --------------------------------- */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaanV2.Math.Fractions;

namespace UnitTest {
    public partial class Math {
        [TestMethod]
        public void UInt64_Simplfy() {
            var example = new UInt64Fraction(200, 150);
            var simp = DaanV2.Math.Math.Simplfy(example);

            Assert.AreEqual(simp.Numerator, (UInt64)4);
            Assert.AreEqual(simp.Denominator, (UInt64)3);
        }

    }
}
