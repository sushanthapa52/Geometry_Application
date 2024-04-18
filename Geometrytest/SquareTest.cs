using GeometryClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrytest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestSquareArea()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSquarePerimeterForNegativeSide()
        {
            // Arrange
            var square = new Square(-5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSquareAreaForZeroSide()
        {
            // Arrange
            var square = new Square(0);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
