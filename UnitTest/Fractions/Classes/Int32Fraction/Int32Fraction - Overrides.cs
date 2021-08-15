/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Fractions {
    public partial class Int32Fraction {
        [TestMethod]
        public void Equals() {
            var A = new DaanV2.Math.Fractions.Int32Fraction(12, 25);
            var B = new DaanV2.Math.Fractions.Int32Fraction(12, 25);

            Assert.AreEqual(A, B);
            Assert.AreEqual(A, A);

            Assert.IsTrue(A.Equals(B));
            Assert.IsTrue(A.Equals(A));
        }
    }
}
