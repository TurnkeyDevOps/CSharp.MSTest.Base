using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.MSTest.Base.Tests
{
    [TestClass]
    public class TestExtensionsTests
    {
        [TestMethod]
        public void ShouldEqual_Postive()
        {
            1.ShouldEqual(1);
        }

        [TestMethod]
        public void ShouldEqual_Negative()
        {
            try
            {
                1.ShouldEqual(2);
                Assert.Fail("Should have thrown TestException");
            }
            catch (TestException)
            {
            }
            
        }
    }
}
