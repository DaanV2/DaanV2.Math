/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Fractions {
    public partial class UInt64Fraction {
        [TestMethod]
        public void Parse() {
            var Text = "127/564";

            var Data = DaanV2.Math.Fractions.UInt64Fraction.Parse(Text);

            Assert.IsTrue(Data.Numerator==127);
            Assert.IsTrue(Data.Denominator==564);
        }
    }
}
