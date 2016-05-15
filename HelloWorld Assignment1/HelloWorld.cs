using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld_Assignment1
{
    [TestClass]
    public class HelloWorld
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            //Arrange
            string expectedResult = "Hello, World!";
            //Act
            string result = COMP123_S2016_Assignment1.Program.HelloWorldToConsole();
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
