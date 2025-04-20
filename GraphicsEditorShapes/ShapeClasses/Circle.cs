using System;
using System.Drawing;
using MathNet.Numerics;



namespace GraphicsEditorShapes.ShapeClasses
{
    public class Circle : Shape
    {
        public int Radius { get; private set; }
        public Circle(int x, int y, int radius, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Radius = radius;
        }
        public override void Draw(Graphics g)
        {
            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillEllipse(brush, X, Y, Radius, Radius);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawEllipse(pen, X, Y, Radius, Radius);
            }
        }
        public override double CalculateArea()
        {
            double area = Constants.Pi * Math.Pow(Radius, 2);
            return area.Round(2);
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }

        public override bool Contains(Point point)
        {
            int dx = point.X - (X + Radius / 2);
            int dy = point.Y - (Y + Radius / 2);
            int distanceSquared = dx * dx + dy * dy;
            return distanceSquared <= Radius / 2 * (Radius / 2);
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 1)
                throw new ArgumentException("Circle requires exactly 1 dimension: radius.");
            Radius = dimensions[0];
        }

        public override Shape Clone()
        {
            return new Circle(X, Y, Radius, IsFilled, ShapeColor);
        }
    }
}
