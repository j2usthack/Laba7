using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Work3Tests
    {
        [TestMethod]
        public void DaysCountByYearTest()
        {
            int year = 2001;
            int expected = 365;

            Work3 w3 = new Work3();
            int actual = w3.DaysCountByYear(year);

            Assert.AreEqual(expected, actual);
        }
    }
}