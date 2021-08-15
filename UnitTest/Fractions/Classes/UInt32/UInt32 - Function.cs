/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Fractions {
    public partial class UInt32Fraction {
        [TestMethod]
        public void Parse() {
            var Text = "127/564";

            var Data = DaanV2.Math.Fractions.UInt32Fraction.Parse(Text);

            Assert.IsTrue(Data.Numerator==127);
            Assert.IsTrue(Data.Denominator==564);
        }
    }
}
