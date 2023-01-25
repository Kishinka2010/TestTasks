using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod]
        public void IsRectangle_NotRectangle_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 2, 2, 4);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Square_3_4_5_Return_6()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 3, 4, 5);
            double expected = 6;

            //act
            double result = triangle.Square();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_10_Return_314_2()
        {
            //arrange
            Circle circle = new Circle("Circle", 10);
            double expected = 314.2;

            //act
            double result = circle.Square();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}