using System;
using System.Collections.Generic;
using GraphicsEditorShapes.ShapeClasses;
using System.Drawing;

namespace GraphicsEditorShapes.ShapeCreation
{
    public class CreateShape : ICreateShape
    {
        public Shape Create(Dictionary<string, string> data)
        {
            string type = data["type"];
            int x = int.Parse(data["x"]);
            int y = int.Parse(data["y"]);
            Color color = Color.FromName(data["color"]);
            bool isFilled = bool.Parse(data["isFilled"]);
            int a = int.Parse(data["a"]);

            if(x < 0 || y < 0 || a < 0)
            {
                throw new ShapeValidationException("Coordinates and dimensions must be non-negative.");
            }

            if (string.IsNullOrEmpty(type))
            {
                throw new ShapeValidationException("Shape type cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(data["color"]))
            {
                throw new ShapeValidationException("Color cannot be null or empty.");
            }

            Shape shape = null;
            switch (type)
            {
                case "Square":
                    shape = new Square(x, y, a, isFilled, color);
                    break;
                case "Rectangle":
                    int b = int.Parse(data["b"]);
                    if (b < 0)
                    {
                        throw new ShapeValidationException("Width must be non-negative.");
                    }
                    shape = new ShapeClasses.Rectangle(x, y, a, b, isFilled, color);
                    break;
                case "Circle":
                    shape = new Circle(x, y, a, isFilled, color);
                    break;
                case "Parallelogram":
                    b = int.Parse(data["b"]);
                    int c = int.Parse(data["c"]);
                    if (b < 0 || c < 0)
                    {
                        throw new ShapeValidationException("Width and height must be non-negative.");
                    }
                    shape = new Parallelogram(x, y, a, b, c, isFilled, color);
                    break;
                case "Rhombus":
                    b = int.Parse(data["b"]);
                    if (b < 0)
                    {
                        throw new ShapeValidationException("Width must be non-negative.");
                    }
                    shape = new Rhombus(x, y, a, b, isFilled, color);
                    break;
                case "Trapezoid":
                    b = int.Parse(data["b"]);
                    c = int.Parse(data["c"]);
                    if (b < 0 || c < 0)
                    {
                        throw new ShapeValidationException("Width and height must be non-negative.");
                    }
                    shape = new Trapezoid(x, y, a, b, c, isFilled, color);
                    break;
                case "Triangle":
                    b = int.Parse(data["b"]);
                    if (b < 0)
                    {
                        throw new ShapeValidationException("Width must be non-negative.");
                    }
                    shape = new Triangle(x, y, a, b, isFilled, color);
                    break;
            }
            return shape;
        }

        public class ShapeValidationException : Exception
        {
            public ShapeValidationException(string message) : base(message) { }
        }
    }
 
}

