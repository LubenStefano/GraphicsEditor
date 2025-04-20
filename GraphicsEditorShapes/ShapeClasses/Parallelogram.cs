using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditorShapes.ShapeClasses
{
    public class Parallelogram : Shape
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public double Angle { get; private set; } 

        public Parallelogram(int x, int y, int width, int height, double angle, bool isFilled, Color color)
            : base(x, y, isFilled, color)
        {
            Width = width;
            Height = height;
            Angle = angle;
        }

        public override void Draw(Graphics g)
        {
            double angleRadians = Angle * Math.PI / 180;

            int offsetX = (int)(Height * Math.Tan(angleRadians));

            Point[] points = new Point[]
            {
                    new Point(X, Y),
                    new Point(X + Width, Y),
                    new Point(X + Width + offsetX, Y + Height),
                    new Point(X + offsetX, Y + Height)
            };

            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillPolygon(brush, points);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawPolygon(pen, points);
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
            double angleRadians = Angle * Math.PI / 180;
            int offsetX = (int)(Height * Math.Tan(angleRadians));

            Point[] points = new Point[]
            {
                new Point(X, Y),
                new Point(X + Width, Y),
                new Point(X + Width + offsetX, Y + Height),
                new Point(X + offsetX, Y + Height)
            };

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(points);
                return path.IsVisible(point);
            }
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 3)
                throw new ArgumentException("Parallelogram requires exactly 3 dimensions: width, height, and angle.");
            Width = dimensions[0];
            Height = dimensions[1];
            Angle = dimensions[2];
        }

        public override Shape Clone()
        {
            return new Parallelogram(X, Y, Width, Height, Angle, IsFilled, ShapeColor);
        }
    }
}
