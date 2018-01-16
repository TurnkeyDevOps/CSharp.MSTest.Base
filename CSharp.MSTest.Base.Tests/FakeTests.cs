using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.MSTest.Base.Tests
{
    [TestClass]
    public class FakeTests
    {
        [TestMethod]
        public void Latitude_Should_Not_Be_Zero()
        {
            //Act
            double result = Fake.Latitude(1, 90);

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeZero();
        }

        [TestMethod]
        public void Longitude_Should_Not_Be_Zero()
        {
            //Act
            double result = Fake.Longitude(-180, -1);

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeZero();
        }

        [TestMethod]
        public void FirstName_Should_Not_Be_Null_Or_Empty()
        {
            //Act
            string result = Fake.FirstName();

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public void LastName_Should_Not_Be_Null_Or_Empty()
        {
            //Act
            string result = Fake.LastName();

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public void AmountDecimal_Should_Be_Greater_Than_Zero()
        {
            //Act
            decimal result = Fake.AmountDecimal();

            //Assert
            Console.WriteLine(result);
            result.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void PercentDecimal_Should_Be_Between_1_and_99_Percent()
        {
            //Act 
            decimal result = Fake.PercentDecimal();

            //Assert
            Console.WriteLine(result);
            result.ShouldBeBetween(.01M, .99M);
        }
    }
}
