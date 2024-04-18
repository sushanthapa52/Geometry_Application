using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryClassLib
{
    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
