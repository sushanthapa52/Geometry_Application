using GeometryClassLib;

namespace Geometrytest
{
    [TestClass]
    public class TestLogic
    {

        // test cases for square
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


        //test cases for rectangle

        [TestMethod]
        public void TestRectangleArea()
        {
            // Arrange
            double length = 6;
            double width = 4;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(24, area);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            // Arrange
            double length = 6;
            double width = 4;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double perimeter = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter);
        }

        [TestMethod]
        public void TestRectangleAreaForZeroDimensions()
        {
            // Arrange
            double length = 0;
            double width = 5;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TestRectanglePerimeterForNegativeDimensions()
        {
            // Arrange
            double length = -6;
            double width = 4;
            Rectangle rectangle = new Rectangle(length, width);

            // Act
            double perimeter = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(0, perimeter);
        }
    }
}