using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManager.Web.Controllers;
using System.Web.Mvc;

namespace StudentManager.Tests
{
    [TestClass]
    public class FizzBuzzControllerTest
    {
        [TestMethod]
        public void Given1Return1()
        {
            //Arrange
            FizzBuzzController controller = new FizzBuzzController();

            //Act
            ViewResult result = controller.Index(1) as ViewResult;

            //Assert
            var expected = "1";
            var actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Given3Return12Fizz()
        {
            //Arrange
            FizzBuzzController controller = new FizzBuzzController();

            //Act
            ViewResult result = controller.Index(3) as ViewResult;

            //Assert
            var expected = "1 2 Fizz";
            var actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Given5Return12Fizz4Buzz()
        {
            //Arrange
            FizzBuzzController controller = new FizzBuzzController();

            //Act
            ViewResult result = controller.Index(5) as ViewResult;

            //Assert
            var expected = "1 2 Fizz 4 Buzz";
            var actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Given15ReturnFizzBuzz()
        {
            //Arrange
            FizzBuzzController controller = new FizzBuzzController();

            //Act
            ViewResult result = controller.Index(15) as ViewResult;

            //Assert
            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
            var actual = result.ViewBag.Output;
            Assert.AreEqual(expected, actual);

        }
    }
}
