using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Rectangle : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int x, int y, int width, int height, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {

            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillRectangle(brush, X, Y, Width, Height);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }

        public override bool Contains(Point point)
        {
            return point.X >= X && point.X <= X + Width &&
                   point.Y >= Y && point.Y <= Y + Height;
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 2)
                throw new ArgumentException("Rectangle requires exactly 2 dimensions: width and height.");
            Width = dimensions[0];
            Height = dimensions[1];
        }

        public override Shape Clone()
        {
            return new Rectangle(X, Y, Width, Height, IsFilled, ShapeColor);
        }
    }
}
