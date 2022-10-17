using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void shouldaddtwonumbers()
        {
            {
                int res = cccalculator.Class1.Add(5, 3);
                Assert.AreEqual(res, 8);
            }
            
        }



        [DataTestMethod]
        [DataRow(1, 2)]
        [TestMethod]
        public void shouldsubstracttwonumbers(int left, int right)
        {
            double res = cccalculator.Class1.Subtract(left, right);
            Assert.AreEqual(res, right-left);
        }
        [TestMethod]
        public void shouldmultiplytwonumbers()
        {
            int res = cccalculator.Class1.Multiply(5, 3);
            Assert.AreEqual(res, 15);
        }
        [TestMethod]
        [TestCategory("divide")]
        public void shoulddividetwonumbers()
        {
            float res = cccalculator.Class1.Division(6, 3);
            
            Assert.AreEqual(res, (float)(6/3));
        }
    }
}
