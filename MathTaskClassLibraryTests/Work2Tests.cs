using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Work2Tests
    {
        [TestMethod]
        public void SolveTest()
        {
            double a = 1;
            double b = 3;
            double c = -4;
            double[] expected = new double[2] { 1, -4 };

            Work2 w2 = new Work2(a, b, c);
            double[] actual = w2.Solve();

            Assert.AreEqual(expected, actual);
        }
    }
}