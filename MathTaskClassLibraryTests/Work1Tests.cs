using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Work1Tests
    {
        [TestMethod]
        public void BuildStringTest()
        {
            int n = 5;
            string expected = "ABCDE";

            Work1 w1 = new Work1();
            string actual = w1.BuildString(n);

            Assert.AreEqual(expected, actual);
        }
    }
}