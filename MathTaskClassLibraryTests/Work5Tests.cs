using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Work5Tests
    {
        [TestMethod]
        public void CalculateTest()
        {
            string num = "6";
            int expected = 12;

            Work5 w5 = new Work5();
            int actual = w5.Calculate(num);

            Assert.AreEqual(expected, actual);

        }
    }
}