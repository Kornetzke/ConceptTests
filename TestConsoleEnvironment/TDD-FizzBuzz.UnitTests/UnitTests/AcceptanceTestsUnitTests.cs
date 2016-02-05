using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_FizzBuzz.AcceptanceTests;
using System.Collections.Generic;

namespace TDD_FizzBuzz.Tests.UnitTests
{
    [TestClass]
    public class AcceptanceTestsUnitTests
    {

        FizzBuzzAcceptanceTests acceptanceTests;

        [TestInitialize]
        public void InitTests()
        {
            acceptanceTests = new FizzBuzzAcceptanceTests();
        }

        [TestMethod]
        public void FindMatchingCommands()
        {
            // Arrange
            List<string> expected = new List<string>() { "getvaluefor" };

            // Act
            List<string> actual = acceptanceTests.FindMatchingCommands("get");

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExecuteStringCommand()
        {
            // Arrange
            string expected = "1";

            // Act
            string actual = acceptanceTests.ExecuteStringCommand("getvaluefor 1");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCommandHelp()
        {
            string help = acceptanceTests.GetCommandHelp("getvaluefor");

            Assert.IsTrue(help.Length > 0);
        }

        [TestMethod]
        public void GetAllCommandNames()
        {
            // Arrange
            List<string> expected = new List<string>() { "getvaluefor" };

            // Act
            List<string> actual = acceptanceTests.GetAllCommandNames();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
