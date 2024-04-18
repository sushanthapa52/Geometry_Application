using GeometryClassLib;

namespace Geometrytest
{
    [TestClass]
    public class RectangleTest
    {

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