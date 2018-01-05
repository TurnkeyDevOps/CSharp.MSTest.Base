using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.MSTest.Base
{
    /// <summary>
    /// BDD Style Extensions that can be used with MSTest, NUnit, or any Testing Framework
    /// </summary>
    public static class TestExtensions
    {
        /// <summary>
        /// Throws an exception if the actual does not equal the expected
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="actual"></param>
        /// <param name="expected"></param>
        /// <param name="message"></param>
        public static void ShouldEqual<T>(this T actual, T expected, string message = null) where T : IComparable
        {
            message = message ?? string.Format("Expected {0} to be equal to {1}", actual, expected);

            if (actual == null && expected != null)
                throw new Exception(message);

            if (actual != null && actual.CompareTo(expected) != 0)
                throw new TestException(message);

        }
    }
}
