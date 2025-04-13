using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
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
            // Convert angle to radians for trigonometric calculations
            double angleRadians = Angle * Math.PI / 180;

            // Calculate the offset for the slanted side
            int offsetX = (int)(Height * Math.Tan(angleRadians));

            // Define the four points of the parallelogram
            Point[] points = new Point[]
            {
                    new Point(X, Y), // Top-left
                    new Point(X + Width, Y), // Top-right
                    new Point(X + Width + offsetX, Y + Height), // Bottom-right
                    new Point(X + offsetX, Y + Height) // Bottom-left
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
