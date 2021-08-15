/*-------------------------------*/
/*  NOTICE: auto generated file  */
/*-------------------------------*/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Fractions {
    public partial class DoubleFraction {
        [TestMethod]
        public void Parse() {
            var Text = "127/564";

            var Data = DaanV2.Math.Fractions.DoubleFraction.Parse(Text);

            Assert.IsTrue(Data.Numerator==127);
            Assert.IsTrue(Data.Denominator==564);
        }
    }
}
