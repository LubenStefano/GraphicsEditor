using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Triangle : Shape
    {
        public int Base { get; private set; }
        public int Height { get; private set; }
        public Triangle(int x, int y, int @base, int height, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Base = @base;
            Height = height;
        }
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[3];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + Base, Y);
            points[2] = new Point(X + Base / 2, Y - Height);

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
            return Base * Height / 2;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }

        public override bool Contains(Point point)
        {
            Point p1 = new Point(X, Y);
            Point p2 = new Point(X + Base, Y);
            Point p3 = new Point(X + Base / 2, Y - Height);

            float area = Math.Abs((p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2.0f);
            float area1 = Math.Abs((point.X * (p2.Y - p3.Y) + p2.X * (p3.Y - point.Y) + p3.X * (point.Y - p2.Y)) / 2.0f);
            float area2 = Math.Abs((p1.X * (point.Y - p3.Y) + point.X * (p3.Y - p1.Y) + p3.X * (p1.Y - point.Y)) / 2.0f);
            float area3 = Math.Abs((p1.X * (p2.Y - point.Y) + p2.X * (point.Y - p1.Y) + point.X * (p1.Y - p2.Y)) / 2.0f);

            return Math.Abs(area - (area1 + area2 + area3)) < 0.01;
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 2)
                throw new ArgumentException("Triangle requires exactly 2 dimensions: base and height.");
            Base = dimensions[0];
            Height = dimensions[1];
        }

        public override Shape Clone()
        {
            return new Triangle(X, Y, Base, Height, IsFilled, ShapeColor);
        }
    }
}
