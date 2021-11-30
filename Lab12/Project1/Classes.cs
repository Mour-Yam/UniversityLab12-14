using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class Shape
    {
        protected string? lineColor;
        public string? LineColor { get { return lineColor; } set { lineColor = value; } }

        protected double lineThickness;
        public double LineThickness { get { return lineThickness; } set { lineThickness = value; } }

        public Shape() { }
        public Shape(string lineColor, double lineThickness)
        {
            this.lineColor = lineColor;
            this.lineThickness = lineThickness;
        }
        public abstract double Perimeter();
        public abstract double Area();

    }

    class Square: Shape
    {
        protected double shapeLength;
        public double ShapeLength { get { return shapeLength; } set { shapeLength = value; } }
        public Square() { }
        public Square(string lineColor, double lineThickness,double shapeLength)
            :base(lineColor,lineThickness)
        {
            this.shapeLength = shapeLength;
        }
        public override double Perimeter() 
        {
            return shapeLength * 4;
        }
        public override double Area() 
        {
            return shapeLength * shapeLength;
        }
    }

    class Rectangle: Square
    {
        protected double shapeWidth;
        public double ShapeWidth { get { return shapeWidth; } set { shapeWidth = value; } }
        public Rectangle() { }
        public Rectangle(string lineColor, double lineThickness, double shapeLength,double shapeWidth)
            : base(lineColor, lineThickness, shapeLength)
        {
            this.shapeWidth = shapeWidth;
        }
        public override double Perimeter()
        {
            return (shapeLength + shapeWidth) * 2;
        }
        public override double Area()
        {
            return shapeLength * shapeLength;
        }

    }

}
