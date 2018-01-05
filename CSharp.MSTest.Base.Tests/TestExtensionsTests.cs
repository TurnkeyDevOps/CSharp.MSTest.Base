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

        [TestMethod, ExpectedException(typeof(TestException))]
        public void ShouldEqual_Negative()
        {
            1.ShouldEqual(2);
        }
    }
}
