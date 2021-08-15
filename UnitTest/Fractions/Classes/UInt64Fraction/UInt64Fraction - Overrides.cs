/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Fractions {
    public partial class UInt64Fraction {
        [TestMethod]
        public void Equals() {
            var A = new DaanV2.Math.Fractions.UInt64Fraction(12, 25);
            var B = new DaanV2.Math.Fractions.UInt64Fraction(12, 25);

            Assert.AreEqual(A, B);
            Assert.AreEqual(A, A);

            Assert.IsTrue(A.Equals(B));
            Assert.IsTrue(A.Equals(A));
        }
    }
}
