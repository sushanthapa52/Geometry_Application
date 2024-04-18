using GeometryClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrytest
{
    [TestClass]
    public class TriangleTest
    {
        // test cases for traingle 

        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(12, perimeter);
        }

        [TestMethod]
        public void TestScaleneTrianglePerimeter()
        {
            // Arrange
            double side1 = 7;
            double side2 = 9;
            double side3 = 13;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(29, perimeter);
        }
    }
}
