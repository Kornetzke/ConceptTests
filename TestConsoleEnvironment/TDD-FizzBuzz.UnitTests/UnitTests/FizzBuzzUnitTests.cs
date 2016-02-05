using System;
using TestConsoleEnvironment.TDD_FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_FizzBuzz.Tests.UnitTests
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        FizzBuzz fizzBuzz;

        [TestInitialize]
        public void TestSetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void FizzBuzzGetFirstValue()
        {
            // Arrange
            string expected = "1";

            // Act
            string actual = fizzBuzz.GetValueFor(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzzGetThirdValue()
        {
            // Arrage
            string expected = "Fizz";

            // Act
            string actual = fizzBuzz.GetValueFor(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzzGetFifthValue()
        {
            // Arrage
            string expected = "Buzz";

            // Act
            string actual = fizzBuzz.GetValueFor(5);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzzGetFifteenthValue()
        {
            // Arrage
            string expected = "FizzBuzz";

            // Act
            string actual = fizzBuzz.GetValueFor(15);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FizzBuzzGetString()
        {

            // Arrage
            string expected ="1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz";

            // Act
            string actual = fizzBuzz.GetRangeOfValues(1, 15);

            

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
