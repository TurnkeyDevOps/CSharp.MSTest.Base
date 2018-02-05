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
        public void ZipCode_Should_Not_Be_Blank()
        {
            //Act
            string result = Fake.ZipCode();

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public void StateAbbreviation_Should_Not_Be_Blank()
        {
            //Act
            string result = Fake.StateAbbreviation();

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public void SSN_Should_Not_Be_Blank()
        {
            //Act
            string result = Fake.SSN();

            //Assert
            Console.WriteLine(result);
            result.ShouldNotBeNullOrEmpty();
        }

        [TestMethod]
        public void BirthDate_Should_Be_Over_21_And_Less_Than_61()
        {
            //Arrange
            int maxYear = DateTime.Now.Year - 21;
            int minYear = DateTime.Now.Year - 60;

            //Act
            DateTime date = Fake.BirthDate();

            //Assert
            Console.WriteLine(date);
            date.Year.ShouldBeBetween(minYear, maxYear);
        }

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

        [TestMethod]
        public void Address_Length_Should_Be_Greater_Than_Zero()
        {
            //Arrage
            int expected = 0;

            //Act
            string result = Fake.address();
            Console.WriteLine(result);

            //Assert
            result.Length.ShouldBeGreaterThan(expected);
        }


    }
}
