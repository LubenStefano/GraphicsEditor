using System;
using System.Drawing;

namespace GraphicsEditorShapes.ShapeClasses
{
    public class Square : Shape
    {
        public int Side { get; private set; }
        public Square(int x, int y, int side, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Side = side;
        }
        public override void Draw(Graphics g)
        {
            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillRectangle(brush, X, Y, Side, Side);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawRectangle(pen, X, Y, Side, Side);
            }
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override bool Contains(Point point)
        {
            return point.X >= X && point.X <= X + Side &&
                   point.Y >= Y && point.Y <= Y + Side;
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 1)
                throw new ArgumentException("Square requires exactly 1 dimension: side length.");
            Side = dimensions[0];
        }

        public override Shape Clone()
        {
            return new Square(X, Y, Side, IsFilled, ShapeColor);
        }
    }
}
