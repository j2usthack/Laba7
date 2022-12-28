using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Work4Tests
    {
        [TestMethod]
        public void EmailCheckTest()
        {
            string email = "sda@sd.com";
            bool expected = true;

            Work4 w4 = new Work4();
            bool actual = w4.EmailCheck(email);

            Assert.AreEqual(expected, actual);

        }
    }
}